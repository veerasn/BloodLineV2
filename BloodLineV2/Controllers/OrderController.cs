using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BloodLineV2.Models;
using MySql.Data.MySqlClient;

namespace BloodLineV2.Controllers
{
    public class OrderController : Controller
    {
        private BBOrderEntities db = new BBOrderEntities();

        // GET: Order
        public ActionResult Index(string searchString)
        {
            var carts = db.Carts.Include(c => c.Member).Where(c => c.Status == 0);

            if (!string.IsNullOrEmpty(searchString))
            {
                if (Regex.IsMatch(searchString, "^[0-9 ]+$"))
                {
                    carts = carts.Where(c => c.PatientID.Contains(searchString));
                }
                else if (Regex.IsMatch(searchString, "^[SC0-9 ]+$", RegexOptions.IgnoreCase))
                {
                    carts = carts.Where(c => c.PatientID.Contains(searchString));
                }
                else if(Regex.IsMatch(searchString, "^[A-Z ]+$", RegexOptions.IgnoreCase))
                {
                    carts = carts.Where(c => c.PatientName.Contains(searchString)||c.Location.Contains(searchString));
                }
                else if (Regex.IsMatch(searchString, "^[#A-Z ]+$", RegexOptions.IgnoreCase))
                {
                    switch (searchString.TrimStart('#'))
                    {
                        case "rc":
                            carts = carts.Where(c => c.NumberRc > 0);
                            break;
                        case "pl":
                            carts = carts.Where(c => c.NumberPl > 0);
                            break;
                        case "pp":
                            carts = carts.Where(c => c.NumberPp > 0);
                            break;
                        case "gs":
                            carts = carts.Where(c => c.NumberGs > 0);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    carts = carts.Where(c => c.Location.Contains(searchString));
                }   
            }

            return View(carts.OrderByDescending(c=>c.CartID).ToList());
        }

        // GET: Order/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Members, "MemberId", "FirstName");
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CartID,UserID,DateCreated,SampleID,SampleTransmitTime,CheckedOut,CheckedOutTime,CheckedIn,CheckedInTime,Urgency,Location,PatientID,PatientName,Status,Items,CheckedOutID,RequiredTime")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Carts.Add(cart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Members, "MemberId", "FirstName", cart.UserID);
            return View(cart);
        }

        // GET: Order/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Members, "MemberId", "FirstName", cart.UserID);
            return View(cart);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CartID,UserID,DateCreated,SampleID,SampleTransmitTime,CheckedOut,CheckedOutTime,CheckedIn,CheckedInTime,Urgency,Location,PatientID,PatientName,Status,Items,CheckedOutID,RequiredTime")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Members, "MemberId", "FirstName", cart.UserID);
            return View(cart);
        }

        // GET: Order/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult GetRequestDetails(long id)
        {
            var cn = new SqlConnection();
            var dt = new DataTable();
            string strCn = ConfigurationManager.ConnectionStrings["BBOrder"].ToString();

            long s = id;
            string queryString = @"SELECT c.CartID, c.SampleID, c.PatientID, c.PatientName, c.UserID,
                                    CONVERT(nvarchar,c.DateCreated, 100) AS DateCreated, 
                                    CONVERT(nvarchar, c.CheckedOutTime, 100) AS CheckedOutTime,
                                    c.CheckedOutID, 
                                    CONVERT(nvarchar, c.RequiredTime, 100) AS RequiredTime, 
                                    CONVERT(nvarchar, c.CheckedInTime, 100) AS CheckedInTime,
                                    c.Urgency, c.[Location], c.Items, ct.CategoryId, ct.CategoryName, n.NoticeText
                                    FROM Cart c
                                    INNER JOIN Notices n ON c.CartID = n.CartID
                                    INNER JOIN Category ct ON n.CategoryId = ct.CategoryId
                                    WHERE n.NoticeText IS NOT NULL AND c.CartID = " + id + " ORDER BY ct.CategoryId";

            SqlDataAdapter da = new SqlDataAdapter(queryString, strCn);
            da.Fill(dt);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;

            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return Json(serializer.Serialize(rows), JsonRequestBehavior.AllowGet);
        }
    }
}
