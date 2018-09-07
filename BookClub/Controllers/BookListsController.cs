using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookClub.Models;

namespace BookClub.Controllers
{
    public class BookListsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BookLists
        public ActionResult Index()
        {
            return View(db.BookLists.ToList());
        }

        // GET: BookLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLists bookLists = db.BookLists.Find(id);
            if (bookLists == null)
            {
                return HttpNotFound();
            }
            return View(bookLists);
        }

        // GET: BookLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookListID,BookListName,BookListType,BookListContent")] BookLists bookLists)
        {
            if (ModelState.IsValid)
            {
                db.BookLists.Add(bookLists);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookLists);
        }

        // GET: BookLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLists bookLists = db.BookLists.Find(id);
            if (bookLists == null)
            {
                return HttpNotFound();
            }
            return View(bookLists);
        }

        // POST: BookLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookListID,BookListName,BookListType,BookListContent")] BookLists bookLists)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookLists).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookLists);
        }

        // GET: BookLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLists bookLists = db.BookLists.Find(id);
            if (bookLists == null)
            {
                return HttpNotFound();
            }
            return View(bookLists);
        }

        // POST: BookLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookLists bookLists = db.BookLists.Find(id);
            db.BookLists.Remove(bookLists);
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
