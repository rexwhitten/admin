using CentACS.Admin.Models;
using CentACS.Admin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    public class ProductController : Controller
    {
        private static ProductRepository repository = new ProductRepository();


        // GET: Product
        public ActionResult Index()
        {
            if (repository.Count == 0)
            {
                repository.TryAdd(1, new ProductModel()
                {
                    Key = 1,
                    Name = "Workplace 360"
                });

                repository.TryAdd(2, new ProductModel()
                {
                    Key = 2,
                    Name = "Schoolplace 360"
                });
            }

            var results = repository.Values.ToList();

            return View(results);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductModel model = new ProductModel();

            if (repository.ContainsKey(id))
            {
                model = repository[id];
            }
            else
            {
                Response.StatusCode = 404;
            }

            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ProductModel createModel = new ProductModel();



            return View(createModel);
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Int32 new_id = repository.GetNextId();
                ProductModel input_model = new ProductModel();

                input_model.Key = new_id;
                input_model.Name = collection["name"];

                repository.TryAdd(new_id, input_model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel model = new ProductModel();

            if (repository.ContainsKey(id))
            {
                model = repository[id];
            }
            else
            {
                Response.StatusCode = 404;
            }

            return View(model);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (repository.ContainsKey(id))
                {
                    repository[id].Name = collection["name"];
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductModel model = new ProductModel();

            if (repository.ContainsKey(id))
            {
                model = repository[id];
            }
            else
            {
                Response.StatusCode = 404;
            }

            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ProductModel deleteModel = new ProductModel();

                if (repository.ContainsKey(id))
                {
                    repository.TryRemove(id, out deleteModel);
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
