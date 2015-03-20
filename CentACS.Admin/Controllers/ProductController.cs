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
        private IRepository<ProductModel> Repository
        {
            get { return Cluster.Products; }
        }


        // GET: Product
        public ActionResult Index()
        {
            var results = Repository.GetAll();

            return View(results);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductModel model = new ProductModel();

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
                ProductModel input_model = new ProductModel();

                input_model.Key = 0;
                input_model.Name = collection["name"];

                Repository.Create(input_model);

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

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var editModel = new ProductModel();

                // Set Values 

                Repository.Update(editModel);

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

            if (Repository.ContainsKey(id))
            {
                model = Repository.GetOne(id);
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
                if (Repository.ContainsKey(id))
                {
                    ProductModel deleteModel = new ProductModel();

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
