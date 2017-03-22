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
    public class EquipmentSessionController : Controller
    {
        private UniversalSportsHubEntities db = new UniversalSportsHubEntities();

        // GET: EquipmentSession
        public ActionResult Index()
        {
            var eQUIP_SESS = db.EQUIP_SESS.Include(e => e.EQUIPMENT).Include(e => e.SESSION);
            return View(eQUIP_SESS.ToList());
        }

        // GET: EquipmentSession/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIP_SESS eQUIP_SESS = db.EQUIP_SESS.Find(id);
            if (eQUIP_SESS == null)
            {
                return HttpNotFound();
            }
            return View(eQUIP_SESS);
        }

        // GET: EquipmentSession/Create
        public ActionResult Create()
        {
            ViewBag.EQUIPMENT_ID = new SelectList(db.EQUIPMENTS, "EQUIPMENT_ID", "EQUIPMENT_NAME");
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE");
            return View();
        }

        // POST: EquipmentSession/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EQUIP_SESS_ID,SESSION_CODE,EQUIPMENT_ID")] EQUIP_SESS eQUIP_SESS)
        {
            if (ModelState.IsValid)
            {
                db.EQUIP_SESS.Add(eQUIP_SESS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EQUIPMENT_ID = new SelectList(db.EQUIPMENTS, "EQUIPMENT_ID", "EQUIPMENT_NAME", eQUIP_SESS.EQUIPMENT_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", eQUIP_SESS.SESSION_CODE);
            return View(eQUIP_SESS);
        }

        // GET: EquipmentSession/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIP_SESS eQUIP_SESS = db.EQUIP_SESS.Find(id);
            if (eQUIP_SESS == null)
            {
                return HttpNotFound();
            }
            ViewBag.EQUIPMENT_ID = new SelectList(db.EQUIPMENTS, "EQUIPMENT_ID", "EQUIPMENT_NAME", eQUIP_SESS.EQUIPMENT_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", eQUIP_SESS.SESSION_CODE);
            return View(eQUIP_SESS);
        }

        // POST: EquipmentSession/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EQUIP_SESS_ID,SESSION_CODE,EQUIPMENT_ID")] EQUIP_SESS eQUIP_SESS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eQUIP_SESS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EQUIPMENT_ID = new SelectList(db.EQUIPMENTS, "EQUIPMENT_ID", "EQUIPMENT_NAME", eQUIP_SESS.EQUIPMENT_ID);
            ViewBag.SESSION_CODE = new SelectList(db.SESSIONS, "SESSION_CODE", "SESSION_CODE", eQUIP_SESS.SESSION_CODE);
            return View(eQUIP_SESS);
        }

        // GET: EquipmentSession/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIP_SESS eQUIP_SESS = db.EQUIP_SESS.Find(id);
            if (eQUIP_SESS == null)
            {
                return HttpNotFound();
            }
            return View(eQUIP_SESS);
        }

        // POST: EquipmentSession/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EQUIP_SESS eQUIP_SESS = db.EQUIP_SESS.Find(id);
            db.EQUIP_SESS.Remove(eQUIP_SESS);
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
