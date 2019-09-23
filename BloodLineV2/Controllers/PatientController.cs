using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodLineV2.Models;

namespace BloodLineV2.Controllers
{
    public class PatientController : Controller
    {
        private readonly BBSEntities bbs = new BBSEntities();
        
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
    }
}