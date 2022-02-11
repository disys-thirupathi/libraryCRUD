using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using libraryCRUD.Models;

namespace libraryCRUD.Controllers
{
    public class book_thirupaController : Controller
    {
        // GET: book_thirupa/Index
        public ActionResult Index()
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.book_thirupa.ToList());
            }
            
        }

        // GET: book_thirupa/Details/5
        public ActionResult Details(int id)
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.book_thirupa.Where(x => x.bookid == id).FirstOrDefault());
            }
        }

        // GET: book_thirupa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: book_thirupa/Create
        [HttpPost]
        public ActionResult Create(book_thirupa book_Thirupa)
        {
            try
            {
                // TODO: Add insert logic here
                using (appdev_trainingDb db = new appdev_trainingDb())
                {
                    db.book_thirupa.Add(book_Thirupa);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book_thirupa/Edit/5
        public ActionResult Edit(int id)
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.book_thirupa.Where(x => x.bookid == id).FirstOrDefault());
            }
        }

        // POST: book_thirupa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, book_thirupa book_Thirupa)
        {
            try
            {

                using (appdev_trainingDb db = new appdev_trainingDb())
                {
                    db.Entry(book_Thirupa).State = EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book_thirupa/Delete/5
        public ActionResult Delete(int id)
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.book_thirupa.Where(x => x.bookid == id).FirstOrDefault());
            }
        }

        // POST: book_thirupa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (appdev_trainingDb db = new appdev_trainingDb())
                {
                    
                        book_thirupa book_Thirupa =db.book_thirupa.Where(x => x.bookid == id).FirstOrDefault();
                        db.book_thirupa.Remove(book_Thirupa);
                        db.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
