using CentACS.Admin.Models;
using CentACS.Admin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    public class LanguageController : Controller
    {
        #region [ Repository ] 
        private IRepository<LanguageModel> Repository
        {
            get { return Cluster.Languages; }
        }
        #endregion

        // GET: Language
        public ActionResult Index()
        {
            List<LanguageModel> result = new List<LanguageModel>();

            result = Repository.GetAll();

            return View(result);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            LanguageModel model = new LanguageModel();

            var results = Repository.Where(L => L.Key == id);

            if (results.Any())
            {
                model = results.First();
            }
            else
            {
                Response.StatusCode = 404;
            }

            return View(model);
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            LanguageModel newModel = new LanguageModel();

            return View(newModel);
        }

        // POST: Language/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                LanguageModel inputModel = new LanguageModel();

                if (collection["name"] != null)
                {
                    inputModel.Name = collection["name"];
                }

                inputModel.Key = 0;

                Repository.Create(inputModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Edit/5
        public ActionResult Edit(int id)
        {
            LanguageModel editModel = new LanguageModel();

            if (Repository.ContainsKey(id))
            {
                editModel = Repository.GetOne(id);
            }
            else
            {
                Response.StatusCode = 404;
            }

            return View(editModel);
        }

        // POST: Language/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (Repository.ContainsKey(id))
                {
                    LanguageModel editModel = new LanguageModel();

                    // Set values

                    Repository.Update(editModel);
                }
                else
                {
                    Response.StatusCode = 404;
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Delete/5
        public ActionResult Delete(int id)
        {
            LanguageModel deleteModel = new LanguageModel();

            if (Repository.ContainsKey(id))
            {
                deleteModel = Repository.GetOne(id);
            }
            else
            {
                Response.StatusCode = 404;
            }


            return View(deleteModel);
        }

        // POST: Language/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (Repository.ContainsKey(id))
                {
                    LanguageModel deleteModel = new LanguageModel();

                    // Set Values

                    Repository.Remove(deleteModel);
                }
                else
                {
                    Response.StatusCode = 404;
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
