using libraryCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace libraryCRUD.Controllers
{
    public class borrowdetailsController : Controller
    {
        // GET: borrowdetails
        public ActionResult Index()
        {

            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.borrowdetails_thirupa.ToList());
            }
        }

        // GET: borrowdetails/Details/5
        public ActionResult Details(int id)
        {

            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.borrowdetails_thirupa.Where(x => x.Studentid == id).FirstOrDefault());
            }
        }

        // GET: borrowdetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: borrowdetails/Create
        [HttpPost]
        public ActionResult Create(borrowdetails_thirupa borrowdetails_thirupa)
        {
            try
            {
                // TODO: Add insert logic here
                using (appdev_trainingDb db = new appdev_trainingDb())
                {
                    db.borrowdetails_thirupa.Add(borrowdetails_thirupa);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: borrowdetails/Edit/5
        public ActionResult Edit(int id)
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.borrowdetails_thirupa.Where(x => x.Studentid == id).FirstOrDefault());
            }
        }

        // POST: borrowdetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, borrowdetails_thirupa borrowdetails_thirupa)
        {
            try
            {
                // TODO: Add update logic here
                using (appdev_trainingDb db = new appdev_trainingDb())
                {
                    db.Entry(borrowdetails_thirupa).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: borrowdetails/Delete/5
        public ActionResult Delete(int id)
        {
            using (appdev_trainingDb db = new appdev_trainingDb())
            {
                return View(db.borrowdetails_thirupa.Where(x => x.Studentid == id).FirstOrDefault());
            }
        }

        // POST: borrowdetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (appdev_trainingDb db = new appdev_trainingDb())
                {

                    borrowdetails_thirupa borrowdetails_Thirupa = db.borrowdetails_thirupa.Where(x => x.Studentid == id).FirstOrDefault();
                    db.borrowdetails_thirupa.Remove(borrowdetails_Thirupa);
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
