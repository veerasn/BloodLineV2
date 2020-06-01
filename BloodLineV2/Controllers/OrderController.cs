using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BloodLineV2.Models;

namespace BloodLineV2.Controllers
{
    public class OrderController : Controller
    {
        private BBOrderEntities db = new BBOrderEntities();

        // GET: Order
        public ActionResult Index()
        {
            var carts = db.Carts.Include(c => c.Member);
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
    }
}
