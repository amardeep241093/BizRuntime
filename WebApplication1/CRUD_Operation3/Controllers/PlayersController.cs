using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_Operation3.Models;

namespace CRUD_Operation3.Controllers
{
    public class PlayersController : Controller
    {
        private RecordContext db = new RecordContext();

        // GET: Players
        public ActionResult Index()
        {
            return View(db.players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Country,Sport,MedalWon,MatchPlayed")] Players players)
        {
            if (ModelState.IsValid)
            {
                db.players.Add(players);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(players);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Country,Sport,MedalWon,MatchPlayed")] Players players)
        {
            if (ModelState.IsValid)
            {
                db.Entry(players).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(players);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Players players = db.players.Find(id);
            db.players.Remove(players);
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
