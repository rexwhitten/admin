
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
        private IRepository<TemplateModel> Repository
        {
            get
            {
                return Cluster.Templates;
            }
        }

        // GET: Template
        public ActionResult Index(Int32? Id)
        {
            List<TemplateModel> viewModel = new List<TemplateModel>();

            if (!Id.HasValue)
                viewModel = Repository.GetAll();
            else
                viewModel = Repository.Query(x => x.Key == Id.Value).ToList();


            return View(viewModel);
        }

        // GET: Template/Details/5
        public ActionResult Details(int id)
        {
            TemplateModel model = new TemplateModel();

            if (Repository.ContainsKey(id))
            {
                model = Repository.GetOne(id);
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
                TemplateModel createModel = new TemplateModel();
                createModel.Key = 0;
                createModel.Name = collection["name"];
                createModel.Product = new ProductModel()
                {
                    Key = Int32.Parse(collection["product_key"]),
                    Name = collection["product_name"]
                };

                Repository.Create(createModel);

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

            if (Repository.ContainsKey(id))
            {
                model.Template = Repository.GetOne(id);
                model.Products = Cluster.Products.GetAll();
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
                if (Repository.ContainsKey(id))
                {
                    var editModel = new TemplateModel();

                    // Set Values 

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

        // GET: Template/Delete/5
        public ActionResult Delete(int id)
        {
            TemplateModel model = new TemplateModel();

            if (Repository.ContainsKey(id))
            {
                model = Repository.GetOne(id);
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
                if (Repository.ContainsKey(id))
                {
                    TemplateModel deleteModel = new TemplateModel();

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
