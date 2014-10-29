using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyHop.Controllers
{
    public class QuanLyNguoiDungController : Controller
    {
        //
        // GET: /QuanLyNguoiDung/

        public ActionResult Index()
        {
            var da = new List<Models.MNguoiDung>{
                new Models.MNguoiDung{Chucvu="giam doc", Hoten = "Nguyen van beo", Username ="alibaba"
                },
                new Models.MNguoiDung{
                    Hoten="tran van kheo",Chucvu="lao cong",Username="bbii"
                }
            };
            return View(da);
        }

        //
        // GET: /QuanLyNguoiDung/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /QuanLyNguoiDung/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /QuanLyNguoiDung/Create

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
        // GET: /QuanLyNguoiDung/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyNguoiDung/Edit/5

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
        // GET: /QuanLyNguoiDung/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyNguoiDung/Delete/5

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
