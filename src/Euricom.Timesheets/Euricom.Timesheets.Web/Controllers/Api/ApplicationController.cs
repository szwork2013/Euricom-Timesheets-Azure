using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Euricom.Timesheets.Web.Models;
using Euricom.Timesheets.Web.Infrastructure;

namespace Euricom.Timesheets.Web.Controllers.Api
{
    public class ApplicationController : ApiController
    {
        private EFContext db = new EFContext();

        // GET api/Application
        public IEnumerable<Application> GetApplications()
        {
            return db.Applications.AsEnumerable();
        }

        // GET api/Application/5
        public Application GetApplication(int id)
        {
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return application;
        }

        // PUT api/Application/5
        public HttpResponseMessage PutApplication(int id, Application application)
        {
            if (ModelState.IsValid && id == application.ApplicationId)
            {
                db.Entry(application).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, application);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Application
        public HttpResponseMessage PostApplication(Application application)
        {
            if (ModelState.IsValid)
            {
                db.Applications.Add(application);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, application);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = application.ApplicationId }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Application/5
        public HttpResponseMessage DeleteApplication(int id)
        {
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Applications.Remove(application);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, application);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}