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
        private static LanguageRepository Repository = new LanguageRepository();
        #endregion

        // GET: Language
        public ActionResult Index()
        {
            List<LanguageModel> result = new List<LanguageModel>();

            if (Repository.Count == 0)
            {
                Repository.TryAdd(1, new LanguageModel()
                {
                    Key = 1,
                    Name = "English"
                });


                Repository.TryAdd(2, new LanguageModel()
                {
                    Key = 2,
                    Name = "Spanish"
                });
            }

            result = Repository.OrderBy(L => L.Key)
                                .Select(L => L.Value)
                                .ToList();

            return View(result);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            LanguageModel model = new LanguageModel();

            var results = Repository.Where(L => L.Key == id);

            if (results.Any())
            {
                model = results.First().Value;
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

                int new_key = Repository.GetNextId();
                inputModel.Key = new_key;

                Repository.TryAdd(new_key, inputModel);

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
                editModel = Repository[id];
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
                    Repository[id].Key = id;
                    Repository[id].Name = collection["name"];
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
                deleteModel = Repository[id];
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
            LanguageModel deleteModel = new LanguageModel();

            try
            {
                if (Repository.ContainsKey(id))
                {
                    Repository.TryRemove(id, out deleteModel);
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
