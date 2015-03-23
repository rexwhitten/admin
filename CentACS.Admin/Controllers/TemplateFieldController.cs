
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    using CentACS.Admin.Models;
    using CentACS.Admin.Repository;
    using System.Dynamic;

    public class TemplateFieldController : Controller
    {
        #region [ Repository ] 
        private IRepository<TemplateFieldModel> Repository
        {
            get { return Cluster.TemplateFields; }
        }
        #endregion

        public ActionResult Index(Int32? id)
        {
            TemplateFieldIndexViewModel viewModel = new TemplateFieldIndexViewModel();


            if (!id.HasValue)
            {
                viewModel.Fields = Repository.GetAll();
                viewModel.Lanuages = Cluster.Languages.GetAll();
            }
            else
            {
                viewModel.Fields = Repository.Query(x => x.LanguageKey == id.Value).ToList();
                viewModel.Lanuages = Cluster.Languages.Query(x => x.Key == id.Value).ToList();
            }


            //viewModel.Fields = Repository.GetAll();
            //viewModel.Lanuages = Cluster.Languages.GetAll();

            return View(viewModel);
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
            TemplateFieldIndexViewModel viewModel = new TemplateFieldIndexViewModel();

            viewModel.Fields = Repository.Query(x => x.LanguageKey == id).ToList();
            viewModel.Lanuages = Cluster.Languages.Query(x => x.Key == id).ToList();


            //viewModel.Fields = Repository.GetAll();
            //viewModel.Lanuages = Cluster.Languages.GetAll();

            return View(viewModel);
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
