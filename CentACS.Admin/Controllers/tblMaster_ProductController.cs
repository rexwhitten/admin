using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CentACS.Admin.App_Code.Data;

namespace CentACS.Admin.Controllers
{
    public class tblMaster_ProductController : ApiController
    {
        private ProductDb db = new ProductDb();

        // GET: api/tblMaster_Product
        public IQueryable<tblMaster_Product> GettblMaster_Product()
        {
            return db.tblMaster_Product;
        }

        // GET: api/tblMaster_Product/5
        [ResponseType(typeof(tblMaster_Product))]
        public async Task<IHttpActionResult> GettblMaster_Product(int id)
        {
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            if (tblMaster_Product == null)
            {
                return NotFound();
            }

            return Ok(tblMaster_Product);
        }

        // PUT: api/tblMaster_Product/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PuttblMaster_Product(int id, tblMaster_Product tblMaster_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblMaster_Product.ProductKey)
            {
                return BadRequest();
            }

            db.Entry(tblMaster_Product).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblMaster_ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tblMaster_Product
        [ResponseType(typeof(tblMaster_Product))]
        public async Task<IHttpActionResult> PosttblMaster_Product(tblMaster_Product tblMaster_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblMaster_Product.Add(tblMaster_Product);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tblMaster_Product.ProductKey }, tblMaster_Product);
        }

        // DELETE: api/tblMaster_Product/5
        [ResponseType(typeof(tblMaster_Product))]
        public async Task<IHttpActionResult> DeletetblMaster_Product(int id)
        {
            tblMaster_Product tblMaster_Product = await db.tblMaster_Product.FindAsync(id);
            if (tblMaster_Product == null)
            {
                return NotFound();
            }

            db.tblMaster_Product.Remove(tblMaster_Product);
            await db.SaveChangesAsync();

            return Ok(tblMaster_Product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblMaster_ProductExists(int id)
        {
            return db.tblMaster_Product.Count(e => e.ProductKey == id) > 0;
        }
    }
}