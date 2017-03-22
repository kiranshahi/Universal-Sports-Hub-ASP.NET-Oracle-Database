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
    public class ActivitiesController : Controller
    {
        private UniversalSportsHubEntities db = new UniversalSportsHubEntities();

        // GET: Activities
        public ActionResult Index()
        {
            return View(db.ACTIVITIES.ToList());
        }

        // GET: Activities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTIVITy aCTIVITy = db.ACTIVITIES.Find(id);
            if (aCTIVITy == null)
            {
                return HttpNotFound();
            }
            return View(aCTIVITy);
        }

        // GET: Activities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ACTIVITY_ID,NAME")] ACTIVITy aCTIVITy)
        {
            if (ModelState.IsValid)
            {
                db.ACTIVITIES.Add(aCTIVITy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aCTIVITy);
        }

        // GET: Activities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTIVITy aCTIVITy = db.ACTIVITIES.Find(id);
            if (aCTIVITy == null)
            {
                return HttpNotFound();
            }
            return View(aCTIVITy);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ACTIVITY_ID,NAME")] ACTIVITy aCTIVITy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCTIVITy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aCTIVITy);
        }

        // GET: Activities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTIVITy aCTIVITy = db.ACTIVITIES.Find(id);
            if (aCTIVITy == null)
            {
                return HttpNotFound();
            }
            return View(aCTIVITy);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACTIVITy aCTIVITy = db.ACTIVITIES.Find(id);
            db.ACTIVITIES.Remove(aCTIVITy);
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
