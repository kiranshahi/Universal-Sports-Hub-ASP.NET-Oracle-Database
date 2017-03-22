using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2016_17_S_CC6001NI_14046931_Kiran_Shahi.Models;

namespace _2016_17_S_CC6001NI_14046931_Kiran_Shahi.Controllers
{
    public class SessionStaffController : Controller
    {
        private UniversalSportsHubEntities db = new UniversalSportsHubEntities();

        // GET: SessionStaff
        public ActionResult Index()
        {
            var sESSION_STAFF = db.SESSION_STAFF.Include(s => s.STAFF).Include(s => s.SESSION);
            return View(sESSION_STAFF.ToList());
        }

        // GET: SessionStaff/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SESSION_STAFF sESSION_STAFF = db.SESSION_STAFF.Find(id);
            if (sESSION_STAFF == null)
            {
                return HttpNotFound();
            }
            return View(sESSION_STAFF);
        }

        // GET: SessionStaff/Create
        public ActionResult Create()
        {
            ViewBag.STAFF_ID = new SelectList(db.STAFFS, "STAFF_ID", "STAFF_NAME");
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE");
            return View();
        }

        // POST: SessionStaff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SESSION_STAFF_ID,STAFF_ID,SESSION_CODE")] SESSION_STAFF sESSION_STAFF)
        {
            if (ModelState.IsValid)
            {
                db.SESSION_STAFF.Add(sESSION_STAFF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.STAFF_ID = new SelectList(db.STAFFS, "STAFF_ID", "STAFF_NAME", sESSION_STAFF.STAFF_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", sESSION_STAFF.SESSION_CODE);
            return View(sESSION_STAFF);
        }

        // GET: SessionStaff/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SESSION_STAFF sESSION_STAFF = db.SESSION_STAFF.Find(id);
            if (sESSION_STAFF == null)
            {
                return HttpNotFound();
            }
            ViewBag.STAFF_ID = new SelectList(db.STAFFS, "STAFF_ID", "STAFF_NAME", sESSION_STAFF.STAFF_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", sESSION_STAFF.SESSION_CODE);
            return View(sESSION_STAFF);
        }

        // POST: SessionStaff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SESSION_STAFF_ID,STAFF_ID,SESSION_CODE")] SESSION_STAFF sESSION_STAFF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sESSION_STAFF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.STAFF_ID = new SelectList(db.STAFFS, "STAFF_ID", "STAFF_NAME", sESSION_STAFF.STAFF_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", sESSION_STAFF.SESSION_CODE);
            return View(sESSION_STAFF);
        }

        // GET: SessionStaff/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SESSION_STAFF sESSION_STAFF = db.SESSION_STAFF.Find(id);
            if (sESSION_STAFF == null)
            {
                return HttpNotFound();
            }
            return View(sESSION_STAFF);
        }

        // POST: SessionStaff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SESSION_STAFF sESSION_STAFF = db.SESSION_STAFF.Find(id);
            db.SESSION_STAFF.Remove(sESSION_STAFF);
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
