using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MercDevs_ej2.Models;

namespace MercDevs_ej2.Controllers
{
    public class Descripcionservicio : Controller
    {
        // GET: Descripcionservicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Descripcionservicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Descripcionservicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Descripcionservicio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Descripcionservicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Descripcionservicio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Descripcionservicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Descripcionservicio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}









