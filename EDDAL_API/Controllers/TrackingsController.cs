using EDDAL;
using EDDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EDDAL_API.Controllers
{
    public class TrackingsController : ApiController
    {
        DALFacade rep = new DALFacade();

        public IEnumerable<Tracking> GetSortings()
        {
            return rep.getAllTrackings();
        }
        // GET api/values
        public Tracking Get(int id)
        {
            var t = rep.getSingleTracking(id);
            if (t == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return t;
        }

        // POST api/values
        public HttpResponseMessage PostTracking(Tracking tracking )
        {
            tracking = rep.addTracking(tracking);
            var response = Request.CreateResponse<Tracking>(HttpStatusCode.Created, tracking);

            string uri = Url.Link("DefaultApi", new { id = tracking.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT api/values/5
        public void PutTracking(Tracking tracking)
        {
            rep.updateTracking(tracking);
        }

        // DELETE api/values/5
        public void DeleteTracking(int id)
        {
            rep.removeTracking(id);
           
        }
    }
}