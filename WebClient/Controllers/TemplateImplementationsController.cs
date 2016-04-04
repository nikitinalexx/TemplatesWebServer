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
using WebServer.Models;

namespace WebServer.Controllers
{
    public class TemplateImplementationsController : ApiController
    {
        private WebServerContext db = new WebServerContext();

        // GET: api/TemplateImplementations
        public IQueryable<TemplateImplementation> GetTemplateImplementations()
        {
            return db.TemplateImplementations;
        }

        // GET: api/TemplateImplementations/5
        [ResponseType(typeof(TemplateImplementation))]
        public async Task<IHttpActionResult> GetTemplateImplementation(int id)
        {
            TemplateImplementation templateImplementation = await db.TemplateImplementations.FindAsync(id);
            if (templateImplementation == null)
            {
                return NotFound();
            }

            return Ok(templateImplementation);
        }

        // PUT: api/TemplateImplementations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTemplateImplementation(int id, TemplateImplementation templateImplementation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != templateImplementation.Id)
            {
                return BadRequest();
            }

            db.Entry(templateImplementation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemplateImplementationExists(id))
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

        // POST: api/TemplateImplementations
        [ResponseType(typeof(TemplateImplementation))]
        public async Task<IHttpActionResult> PostTemplateImplementation(TemplateImplementation templateImplementation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TemplateImplementations.Add(templateImplementation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = templateImplementation.Id }, templateImplementation);
        }

        // DELETE: api/TemplateImplementations/5
        [ResponseType(typeof(TemplateImplementation))]
        public async Task<IHttpActionResult> DeleteTemplateImplementation(int id)
        {
            TemplateImplementation templateImplementation = await db.TemplateImplementations.FindAsync(id);
            if (templateImplementation == null)
            {
                return NotFound();
            }

            db.TemplateImplementations.Remove(templateImplementation);
            await db.SaveChangesAsync();

            return Ok(templateImplementation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TemplateImplementationExists(int id)
        {
            return db.TemplateImplementations.Count(e => e.Id == id) > 0;
        }
    }
}