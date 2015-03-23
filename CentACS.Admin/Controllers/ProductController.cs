using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CentACS.Admin.Data;

namespace CentACS.Admin.Controllers
{
    public class ProductController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: Product
        public async Task<ActionResult> Index()
        {
            return View(await db.tblMaster_Product.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            if (tblMaster_Product == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductKey,ProductID,ProductName,Rank,DateCreated")] tblMaster_Product tblMaster_Product)
        {
            if (ModelState.IsValid)
            {
                db.tblMaster_Product.Add(tblMaster_Product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblMaster_Product);
        }

        // GET: Product/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            if (tblMaster_Product == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductKey,ProductID,ProductName,Rank,DateCreated")] tblMaster_Product tblMaster_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMaster_Product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblMaster_Product);
        }

        // GET: Product/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            if (tblMaster_Product == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            db.tblMaster_Product.Remove(tblMaster_Product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
