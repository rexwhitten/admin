
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    using CentACS.Admin.Models;
    using CentACS.Admin.Repository;

    public class TemplateFieldController : Controller
    {
        private IRepository<TemplateFieldModel> Repository
        {
            get { return Cluster.TemplateFields; }
        }

        
        public ActionResult Index()
        {
            return View();
        }

        // GET: TemplateField/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TemplateField/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemplateField/Create
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

        // GET: TemplateField/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TemplateField/Edit/5
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

        // GET: TemplateField/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TemplateField/Delete/5
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
