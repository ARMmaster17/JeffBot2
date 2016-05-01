using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JeffBot2.Models;

namespace JeffBot2.Controllers
{
    public class NcsController : Controller
    {
        private NcDBContext db = new NcDBContext();

        // GET: Ncs
        public ActionResult Index()
        {
            return View(db.Ncs.ToList());
        }

        // GET: Ncs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nc nc = db.Ncs.Find(id);
            if (nc == null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }

        // GET: Ncs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ncs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,A,B,C,Count")] Nc nc)
        {
            if (ModelState.IsValid)
            {
                db.Ncs.Add(nc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nc);
        }

        // GET: Ncs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nc nc = db.Ncs.Find(id);
            if (nc == null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }

        // POST: Ncs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,A,B,C,Count")] Nc nc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        // GET: Ncs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nc nc = db.Ncs.Find(id);
            if (nc == null)
            {
                return HttpNotFound();
            }
            return View(nc);
        }

        // POST: Ncs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nc nc = db.Ncs.Find(id);
            db.Ncs.Remove(nc);
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
