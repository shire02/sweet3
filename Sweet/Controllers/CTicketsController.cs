using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sweet.Models;

namespace Sweet.Controllers
{
    public class CTicketsController : Controller
    {//database
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CTickets
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(db.NewTickets.ToList());
        }

        // GET: CTickets/Details/5
        public ActionResult Details(int? id)
        {
            ModelState.Clear();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTickets cTickets = db.NewTickets.Find(id);
            if (cTickets == null)
            {
                return HttpNotFound();
            }
            return View(cTickets);
        }

        // GET: CTickets/Create
        public ActionResult Create()
        {
            ModelState.Clear();

            return View();
        }

        // POST: CTickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,Email,Issue,Description,Date,Status")] CTickets cTickets)
        {
            if (ModelState.IsValid)
            {
                db.NewTickets.Add(cTickets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cTickets);
        }

        // GET: CTickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTickets cTickets = db.NewTickets.Find(id);
            if (cTickets == null)
            {
                return HttpNotFound();
            }
            return View(cTickets);
        }

        // POST: CTickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Email,Issue,Description,Date,Status")] CTickets cTickets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTickets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cTickets);
        }

        // GET: CTickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTickets cTickets = db.NewTickets.Find(id);
            if (cTickets == null)
            {
                return HttpNotFound();
            }
            return View(cTickets);
        }

        // POST: CTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CTickets cTickets = db.NewTickets.Find(id);
            db.NewTickets.Remove(cTickets);
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
