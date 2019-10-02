using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BloodLineV2.Models;
using BloodLineV2.ViewModels;
using Newtonsoft.Json;

namespace BloodLineV2.Controllers
{
    public class PatientController : Controller
    {
        private readonly BBSEntities bbs = new BBSEntities();
        private readonly LMDLABEntities lmd = new LMDLABEntities();
        
        // GET: Patient
        public ActionResult Index(string searchString)
        {
            var patients = from p in bbs.PATIENTS select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(searchString, "^[0-9 ]+$"))
                {
                    patients = patients.Where(p => p.PATNUMBER.Contains(searchString));
                }
                else
                {
                    patients = patients.Where(p => p.NAME.Contains(searchString));
                }
            }
            else
            {
                patients = patients.Where(p => p.PATNUMBER.Contains("00777"));
            }
            return View(patients);
        }

        // GET: mains/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BBSPATIENT Patient = bbs.PATIENTS.Find(id);

            if (Patient == null)
            {
                return HttpNotFound();
            }

            //Test requests
            var testrequests = (
                from rq in bbs.REQUESTS
                join test in bbs.TESTS
                on rq.ACCESSNUMBER equals test.ACCESSNUMBER
                where rq.PATNUMBER == id
                orderby rq.REQDATE descending
                select new
                {
                    RequestDate = rq.REQDATE,
                    AccessNumber = rq.ACCESSNUMBER,
                    TestCode = test.TESTCODE,
                    TestResult = test.RESULT
                }
                ).ToList();

            //Create array for populating results table
            int ireq = testrequests.Select(x => x.AccessNumber).Distinct().Count();
            ViewBag.TestCount = ireq;

            string abo = "", rh = "", reqvaliddate = "none";
            int aboerr = 0, rherr = 0, abserr = 0, abonum = 0, absnum = 0, reqvalid = 0;

            if (ireq > 0)
            {
                int j = 0;
                string[,] res = new string[ireq, 8];
                string accnum = testrequests.First().AccessNumber;

                for (int i = 0; i < testrequests.Count(); i++)
                {
                    if (accnum != testrequests[i].AccessNumber)
                    {
                        j = j + 1;
                        accnum = testrequests[i].AccessNumber;
                    }

                    res[j, 0] = testrequests[i].AccessNumber;
                    res[j, 1] = testrequests[i].RequestDate.Value.ToString("HH:mm dd MMM yyyy");

                    switch (testrequests[i].TestCode)
                    {
                        case "RJ":
                            res[j, 2] = testrequests[i].TestResult;
                            break;
                        case "GROUP":
                        case "ABO":
                            res[j, 3] = testrequests[i].TestResult;
                            //Check for any abo discrepancies
                            if (abo == "" && testrequests[i].TestResult != null)
                            {
                                abo = testrequests[i].TestResult;
                                abonum = abonum + 1;
                            }
                            else
                            {
                                abonum = abonum + 1;
                            }
                            if (testrequests[i].TestResult != abo && testrequests[i].TestResult != null)
                            {
                                aboerr = 1;
                            }
                            //Check if any sample with ABO determination within last 3 days
                            if (testrequests[i].RequestDate != null && (DateTime.Today - testrequests[i].RequestDate).Value.Days < 180)
                            {
                                reqvalid = reqvalid + 1;
                                reqvaliddate = testrequests[i].RequestDate.ToString();
                            }
                            break;
                        case "RH":
                            res[j, 4] = testrequests[i].TestResult;
                            //Check for any rh discrepancies
                            if (rh == "" && testrequests[i].TestResult != null)
                            {
                                rh = testrequests[i].TestResult;
                            }
                            if (testrequests[i].TestResult != rh && testrequests[i].TestResult != null)
                            {
                                rherr = 1;
                            }
                            break;
                        case "DAT":
                            res[j, 5] = testrequests[i].TestResult;
                            break;
                        case "ABS":
                            res[j, 6] = testrequests[i].TestResult;
                            //Count number of abs with neg results
                            if (testrequests[i].TestResult != null && testrequests[i].TestResult.Contains("ABNEG"))
                            {
                                absnum = absnum + 1;
                            }
                            //Check for any abs positives
                            if (testrequests[i].TestResult != null && testrequests[i].TestResult.Contains("ABPOS"))
                            {
                                abserr = abserr + 1;
                            }
                            break;
                        case "ABID":
                            res[j, 7] = testrequests[i].TestResult;
                            break;
                    }
                }
                ViewData["TestResults"] = res;
                ViewBag.AboErr = aboerr; ViewBag.RhErr = rherr; ViewBag.AbsErr = abserr; ViewBag.Abonum = abonum; ViewBag.Absnum = absnum;
                ViewBag.ReqValid = reqvalid; ViewBag.ReqValidDate = reqvaliddate;
            }

            //Product requests

            var prodrequests = (

                from p in bbs.PATIENTS
                join r in bbs.REQUESTS on p.PATNUMBER equals r.PATNUMBER into List1
                from r in List1.DefaultIfEmpty()
                join rp in bbs.REQUEST_PRODUCT on r.ACCESSNUMBER equals rp.ACCESSNUMBER into List2
                from rp in List2.DefaultIfEmpty()
                join pr in bbs.PRODUCTS on rp.PRODUCTID equals pr.PRODUCTID into List3
                from pr in List3.DefaultIfEmpty()
                where p.PATNUMBER == id
                orderby r.REQDATE descending
                select new
                {
                    Patnumber = p.PATNUMBER,
                    PatName = p.NAME,
                    BirthDate = p.BIRTHDATE,
                    Sex = p.SEX,
                    Patgroup = p.PATGROUP,
                    Abo = p.ABO,
                    Rh = p.RHFACTOR,
                    Rhpheno = p.RHPHENO,
                    Ab = p.ANTIBODIES,
                    Accessno = r.ACCESSNUMBER,
                    Reqdate = r.REQDATE,
                    Prodcode = pr.PRODCODE,
                    Prodnum = pr.PRODNUM,
                    Mstatus = rp.MSTATUS,
                    Pstatus = rp.PSTATUS,
                    Reservdate = rp.RESERVDATE,
                    Xmatchdate = rp.XMATCHDATE,
                    Issuedate = rp.ISSUEDATE,
                    Returndate = rp.RETURNDATE,
                    Transreaction = rp.TRANSREACTION

                }).ToList()

                .Select(x => new PatientDetailViewModel()
                {
                    PATNUMBER = x.Patnumber,
                    NAME = x.PatName,
                    BIRTHDATE = x.BirthDate,
                    SEX = x.Sex,
                    PATGROUP = x.Patgroup,
                    ABO = x.Abo,
                    RHFACTOR = x.Rh,
                    RHPHENO = x.Rhpheno,
                    ANTIBODIES = x.Ab,
                    ACCESSNUMBER = x.Accessno,
                    REQDATE = x.Reqdate,
                    PRODCODE = x.Prodcode,
                    PRODNUM = x.Prodnum,
                    MSTATUS = x.Mstatus,
                    PSTATUS = x.Pstatus,
                    RESERVDATE = x.Reservdate,
                    XMATCHDATE = x.Xmatchdate,
                    ISSUEDATE = x.Issuedate,
                    RETURNDATE = x.Returndate,
                    TRANSREACTION = x.Transreaction
                });

            if (prodrequests.Count(x => x.PRODNUM != null) > 0)
            {
                ViewBag.Rccount = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC");
                ViewBag.Xm = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.MSTATUS == 2);

                ViewBag.Reserved = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 2);
                ViewBag.Issued = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 3);
                ViewBag.Transfused = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 4);
                ViewBag.Returned = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 6);
                ViewBag.Reaction = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 9);

                ViewBag.InReserve = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "RC" && x.PSTATUS == 2 && (DateTime.Today - x.XMATCHDATE).Value.Days < 3);

                ViewBag.Plcount = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "PL");
                ViewBag.PlIssued = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "PL" && x.PSTATUS == 3);
                ViewBag.PlTransfused = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "PL" && x.PSTATUS == 4);
                ViewBag.PlReturned = prodrequests.Count(x => x.PRODNUM != null && x.PRODCODE.Substring(0, 2) == "PL" && x.PSTATUS == 6);

                ViewBag.Fpcount = prodrequests.Count(x => x.PRODNUM != null && (x.PRODCODE.Substring(0, 2) == "FF" || x.PRODCODE.Substring(0, 2) == "CR"));
                ViewBag.FpIssued = prodrequests.Count(x => x.PRODNUM != null && (x.PRODCODE.Substring(0, 2) == "FF" || x.PRODCODE.Substring(0, 2) == "CR") && x.PSTATUS == 3);
                ViewBag.FpTransfused = prodrequests.Count(x => x.PRODNUM != null && (x.PRODCODE.Substring(0, 2) == "FF" || x.PRODCODE.Substring(0, 2) == "CR") && x.PSTATUS == 4);
                ViewBag.FpReturned = prodrequests.Count(x => x.PRODNUM != null && (x.PRODCODE.Substring(0, 2) == "FF" || x.PRODCODE.Substring(0, 2) == "CR") && x.PSTATUS == 6);
            }
            else
            {
                ViewBag.Rccount = 0;
                ViewBag.Plcount = 0;
                ViewBag.Fpcount = 0;
            }


            ViewBag.Tcount = prodrequests.Count();

            //LMD results for chart
            var result = (
                    from tst in lmd.TESTS
                    join rq in lmd.REQUESTS
                    on tst.REQUESTID equals rq.REQUESTID
                    join pt in lmd.PATIENTS
                    on rq.PATID equals pt.PATID
                    where pt.PATNUMBER == id && (tst.CHAPID == 36 | tst.CHAPID == 40)
                        && tst.RESVALUE != null && rq.COLLECTIONDATE != null
                    orderby rq.COLLECTIONDATE ascending
                    select new
                    {
                        Interval = DbFunctions.DiffDays(DateTime.Now, rq.COLLECTIONDATE),
                        Resvalue = tst.RESVALUE,
                        TestId = tst.TESTID
                    }
                    ).ToList();

            //Hgb
            var hgb = result.Where(i => i.TestId == 2719).ToList();
            int iHgb = hgb.Count;
            ViewBag.iHgb = iHgb;

            string cHgb = "";

            if (iHgb > 0)
            {
                double[] y = new double[iHgb];
                string[] x = new string[iHgb];
                for (int i = 0; i < iHgb; i++)
                {
                    if (double.TryParse(hgb[i].Resvalue, out double temp))
                    {
                        y[i] = temp;
                        x[i] = hgb[i].Interval.ToString();
                    }
                }

                ViewBag.xHb = x;
                ViewBag.yHb = y;

                int UHgb = x.GetUpperBound(0);
                ViewBag.UHgb = UHgb;

                switch (x[UHgb])
                {
                    case "0":
                        cHgb = "The patient's last Hb result was " + y[UHgb] + "g/L checked today.";
                        break;
                    case "1":
                    case "2":
                    case "3":
                        cHgb = "The patient's last Hb result was " + y[UHgb] + " g/L checked " + x[UHgb] + " days ago.";
                        break;
                    default:
                        cHgb = "The patient's last Hb result was " + y[UHgb] + " g/L checked " + x[UHgb] + " days ago. " +
                                "Please ensure a recent Hb level has been determined " +
                                "before proceeding to order red cells.";
                        break;
                }
            }
            else
            {
                cHgb = "No Hb results are available for this patient. Please ensure that the Hb level has been determined " +
                        "before proceeding to order red cells.";
                double[] y = { 0 };
                ViewBag.yHb = y;
                ViewBag.UHgb = 0;
            }

            ViewBag.cHgb = cHgb;

            //Mcv
            var mcv = result.Where(i => i.TestId == 1848).ToList();
            int iMcv = mcv.Count;
            ViewBag.iMcv = iMcv;

            string cMcv = "";

            if (iMcv > 0)
            {
                int[] y = new int[iMcv];
                string[] x = new string[iMcv];
                for (int i = 0; i < iMcv; i++)
                {
                    if (int.TryParse(mcv[i].Resvalue, out int temp))
                    {
                        y[i] = temp;
                        x[i] = mcv[i].Interval.ToString();

                        if (y[0] < 76)
                        {
                            cMcv = "The patient's MCV is " + y[0] + " fL which is low. " +
                                    "Investigations to exclude iron deficiency or thalassaemia would be advised, if not already done. " +
                                    "Iron therapy would be warranted before an elective red cell transfusion, if there is evidence to indicate iron deficiency.";
                        }
                    }
                }

                ViewBag.xMcv = x;
                ViewBag.yMcv = y;
            }

            ViewBag.cMcv = cMcv;

            //Platelet
            var plt = result.Where(i => i.TestId == 1999).ToList();
            int iPlt = plt.Count;
            string cPlt = "";
            ViewBag.iPlt = iPlt;

            if (iPlt > 0)
            {
                double[] y = new double[iPlt];
                string[] x = new string[iPlt];
                for (int i = 0; i < iPlt; i++)
                {
                    if (double.TryParse(plt[i].Resvalue, out double temp))
                    {
                        y[i] = temp;
                        x[i] = plt[i].Interval.ToString();
                    }
                }

                ViewBag.xPlt = x;
                ViewBag.yPlt = y;

                int UPlt = x.GetUpperBound(0);
                ViewBag.UPlt = UPlt;

                switch (x[UPlt])
                {
                    case "0":
                        cPlt = "The patient's last platelet count was " + y[UPlt] + " x 10^9/L checked today.";
                        break;
                    case "1":
                        cPlt = "The patient's last platelet count was " + y[UPlt] + " x 10^9/L checked yesterday.";
                        break;
                    default:
                        cPlt = "The patient's last platelet count was " + y[UPlt] + " x 10^9/L checked " + x[UPlt] + " days ago. " +
                                "Please ensure a recent platelet count has been determined " +
                                "before proceeding to order platelets.";
                        break;
                }
            }
            else
            {
                cPlt = "No platelet counts are available for this patient. Please ensure that the platelet count has been determined " +
                        "before proceeding to order platelets.";
                double[] y = { 0 };
                ViewBag.yPlt = y;
                ViewBag.UPlt = 0;
            }

            ViewBag.cPlt = cPlt;

            //INR
            var inr = result.Where(i => i.TestId == 2761).ToList();
            int iInr = inr.Count;
            ViewBag.iInr = iInr;

            if (iInr > 0)
            {
                double[] y = new double[iInr];
                string[] x = new string[iInr];
                for (int i = 0; i < iInr; i++)
                {
                    if (double.TryParse(inr[i].Resvalue, out double temp))
                    {
                        y[i] = temp;
                        x[i] = inr[i].Interval.ToString();
                    }
                }

                ViewBag.xInr = x;
                ViewBag.yInr = y;
            }

            //APTT
            var apt = result.Where(i => i.TestId == 2704).ToList();
            int iApt = apt.Count;
            ViewBag.iApt = iApt;

            if (iApt > 0)
            {
                double[] y = new double[iApt];
                string[] x = new string[iApt];
                for (int i = 0; i < iApt; i++)
                {
                    if (double.TryParse(apt[i].Resvalue, out double temp))
                    {
                        y[i] = temp;
                        x[i] = apt[i].Interval.ToString();
                    }
                }

                ViewBag.xApt = x;
                ViewBag.yApt = y;
            }

            //Create table for choosing blood products
            ProductInfoModel productInfoModel = new ProductInfoModel();
            ViewBag.ProductInfo = productInfoModel.ProductInfoAll();

            //Create dropdown for indications
            ProductInfoModel IndicationModel = new ProductInfoModel();
            ViewBag.Indications = IndicationModel.IndicationAll();

            //return View("Details",Patient);
            return View("Details", prodrequests);
        }
    }
}