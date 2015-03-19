
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Controllers
{
    using CentACS.Admin.Repository;
    using CentACS.Admin.Models;
    using System.Dynamic;

    public class TemplateController : Controller
    {
        private TemplateRepository repository = new TemplateRepository();

        // GET: Template
        public ActionResult Index()
        {

            if (repository.Count == 0)
            {
                repository.TryAdd(1, new TemplateModel()
                {
                    Key = 1,
                    Name = "Capacitor",
                    Product = new ProductModel()
                    {
                        Key = 1,
                        Name = "Workplace 360"
                    }
                });
                repository.TryAdd(2, new TemplateModel()
                {
                    Key = 2,
                    Name = "Trait",
                    Product = new ProductModel()
                    {
                        Key = 1,
                        Name = "Workplace 360"
                    }
                });
            }

            var model = repository.Values.ToList();

            return View(model);
        }

        // GET: Template/Details/5
        public ActionResult Details(int id)
        {
            TemplateModel model = new TemplateModel();

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

        // GET: Template/Create
        public ActionResult Create()
        {
            dynamic model = new ExpandoObject();

            model.Template = new TemplateModel();
            model.Products = new List<ProductModel>()
            {
                new ProductModel() {
                     Key = 1,
                     Name = "Workplace 360"
                },
                new ProductModel() {
                     Key = 1,
                     Name = "Schoolplace 360"
                },
            };


            return View(model);
        }

        // POST: Template/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Int32 new_key = repository.GetNextId();

                TemplateModel createModel = new TemplateModel();
                createModel.Key = new_key;
                createModel.Name = collection["name"];
                createModel.Product = new ProductModel()
                {
                    Key = Int32.Parse(collection["product_key"]),
                    Name = collection["product_name"]
                };

                repository.TryAdd(new_key, createModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Template/Edit/5
        public ActionResult Edit(int id)
        {
            dynamic model = new ExpandoObject();

            if (repository.ContainsKey(id))
            {
                model.Template = repository[id];
                model.Products = new List<ProductModel>()
                {
                    new ProductModel() {
                         Key = 1,
                         Name = "Workplace 360"
                    },
                    new ProductModel() {
                         Key = 1,
                         Name = "Schoolplace 360"
                    },
                };
            }
            else
            {
                Response.StatusCode = 404;
            }


            return View(model);
        }

        // POST: Template/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (repository.ContainsKey(id))
                {
                    TemplateModel model = new TemplateModel();

                    model.Key = id;
                    model.Name = collection["name"];
                    model.Product = new ProductModel()
                    {
                        Key = Int32.Parse(collection["product_key"]),
                        Name = collection["product_name"]
                    };

                    repository[id] = model;
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

        // GET: Template/Delete/5
        public ActionResult Delete(int id)
        {
            TemplateModel model = new TemplateModel();

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

        // POST: Template/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                TemplateModel deleteModel = new TemplateModel();

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
