using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    public class LanguageController : Controller
    {
        private static List<LanguageModel> Repository = new List<LanguageModel>();


        // GET: Language
        public ActionResult Index()
        {
            List<LanguageModel> result = new List<LanguageModel>();

            if (Repository.Count == 0)
            {
                Repository.Add(new LanguageModel()
                {
                    Key = 1,
                    Name = "English"
                });


                Repository.Add(new LanguageModel()
                {
                    Key = 2,
                    Name = "Spanish"
                });
            }

            result = Repository.OrderBy(L => L.Key)
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

                int new_key = Repository.Select(s => s.Key).Max() + 1;
                inputModel.Key = new_key;

                Repository.Add(inputModel);

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

            

            return View();
        }

        // POST: Language/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (Repository.Where(L => L.Key == id).Any())
                {
                    int index = Repository.FindIndex(L => L.Key == id);
                    Repository[index].Key = id;
                    Repository[index].Name = collection["name"];
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

            if (Repository.Where(L => L.Key == id).Any())
            {
                int index = Repository.FindIndex(L => L.Key == id);
                deleteModel = Repository[index];
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
                if (Repository.Where(L => L.Key == id).Any())
                {
                    int index = Repository.FindIndex(L => L.Key == id);

                    Repository.RemoveAt(index);
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
