using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCongVan.Controllers
{
    public class QuanLyHopController : Controller
    {
        //
        // GET: /QuanLyHop/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /QuanLyHop/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /QuanLyHop/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /QuanLyHop/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /QuanLyHop/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyHop/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /QuanLyHop/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyHop/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
