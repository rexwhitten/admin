using CentACS.Admin.Data;
using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;


namespace CentACS.Admin.Controllers
{
    public class TranslationController : Controller
    {
        #region [ Properties ] 
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();
        #endregion


        // GET: Translation
        public ActionResult Index()
        {
            var model = new TranslationIndexModel();

            model.ProductsList = db.tblMaster_Product.Where(p => p.ProductKey > 0).ToList();
            model.LanguageList = db.tblMaster_Language.Where(p => p.LanguageKey > 0).ToList();

            foreach (var product in model.ProductsList)
            {
                foreach (var lang in model.LanguageList)
                {
                    TranslationModel item = new TranslationModel();
                    item.Product = product;
                    item.Language = lang;
                    model.TranslationList.Add(item);
                }
            }


            return View(model);
        }

        // GET: Translation/Details/{product
        public ActionResult Details(Int32 languageKey, Int32 productKey)
        {
            TranslationDetailViewModel model = new Models.TranslationDetailViewModel();

            // Build Model
            model.Language = this.db.tblMaster_Language.Where(l => l.LanguageKey == languageKey).FirstOrDefault();
            model.Product = this.db.tblMaster_Product.Where(p => p.ProductKey == productKey).FirstOrDefault();

            return View(model);
        }

        // GET: Translation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Translation/Create
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

        // GET: Translation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Translation/Edit/5
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

        // GET: Translation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Translation/Delete/5
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
