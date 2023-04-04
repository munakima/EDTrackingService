using EDBLL_API.Infrastructure;
using EDDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EDBLL_API.Controllers
{
    public class TrackingController : ApiController

    {
        // GET api/values
        public IEnumerable<TrackingDTO> Get()
        {
            DALServiceGateway<IEnumerable<TrackingDTO>> gate = new DALServiceGateway<IEnumerable<TrackingDTO>>();
            //var s = gate.GetItems("api/Trackings/");
            //s.Include(b => b.Customer).Include(b => b.Room).ToList();
            return gate.GetItems("api/Trackings/");
        }

        // GET api/values/5
        public TrackingDTO GetTrackingDTO(int id)
        {
            DALServiceGateway<TrackingDTO> gate = new DALServiceGateway<TrackingDTO>();

            TrackingDTO t = gate.GetItems("api/Trackings/" + id + "");
            return t;
        }

        // POST api/values
        public HttpResponseMessage PostTracking(TrackingDTO tracking)
        {
            DALServiceGateway<TrackingDTO> gate = new DALServiceGateway<TrackingDTO>();

            tracking = gate.PostItems("api/Trackings/", tracking);
            var response = Request.CreateResponse<TrackingDTO>(HttpStatusCode.Created, tracking);

            string uri = Url.Link("DefaultApi", new { id = tracking.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT api/values/5
        public void Put(TrackingDTO tracking)
        {
            DALServiceGateway<TrackingDTO> gate = new DALServiceGateway<TrackingDTO>();

            gate.PutItems("api/Trackings/ ", tracking);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            DALServiceGateway<TrackingDTO> gate = new DALServiceGateway<TrackingDTO>();

            gate.DeleteItems("api/Trackings/" + id + "");
        }
    }
}
