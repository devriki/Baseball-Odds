using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Baseball_Odds_Analytics.Models;

namespace Baseball_Odds_Analytics.Controllers
{
    public class OddsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Odds
        public ActionResult Index()
        {
            return View(db.Odds.ToList());
        }

        // GET: Odds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odds odds = db.Odds.Find(id);
            if (odds == null)
            {
                return HttpNotFound();
            }
            return View(odds);
        }

        // GET: Odds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Odds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OddsId,HomeTeam,AwayTeam,Date,HomeOdds,AwayOdds")] Odds odds)
        {
            if (ModelState.IsValid)
            {
                db.Odds.Add(odds);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odds);
        }

        // GET: Odds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odds odds = db.Odds.Find(id);
            if (odds == null)
            {
                return HttpNotFound();
            }
            return View(odds);
        }

        // POST: Odds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OddsId,HomeTeam,AwayTeam,Date,HomeOdds,AwayOdds")] Odds odds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odds).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(odds);
        }

        // GET: Odds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odds odds = db.Odds.Find(id);
            if (odds == null)
            {
                return HttpNotFound();
            }
            return View(odds);
        }

        // POST: Odds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Odds odds = db.Odds.Find(id);
            db.Odds.Remove(odds);
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
