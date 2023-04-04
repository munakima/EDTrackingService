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
    public class SortingsController : ApiController
    {    
        // GET api/values
        public IEnumerable<SortingDTO> Get()
        {
            DALServiceGateway<IEnumerable<SortingDTO>> gate = new DALServiceGateway<IEnumerable<SortingDTO>>();
            return gate.GetItems("api/Sortings/");
        }

        // GET api/values/5
        public SortingDTO GetSortingDTO(int id)
        {
            DALServiceGateway<SortingDTO> gate = new DALServiceGateway<SortingDTO>();

            SortingDTO s = gate.GetItems("api/Sortings/" + id + "");
            return s;
        }

        // POST api/values
        public HttpResponseMessage PostSorting(SortingDTO sorting)
        {
            DALServiceGateway<SortingDTO> gate = new DALServiceGateway<SortingDTO>();

            sorting = gate.PostItems("api/Sortings/", sorting);
            var response = Request.CreateResponse<SortingDTO>(HttpStatusCode.Created, sorting);

            string uri = Url.Link("DefaultApi", new { id = sorting.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT api/values/5
        public void Put(SortingDTO sorting)
        {
            DALServiceGateway<SortingDTO> gate = new DALServiceGateway<SortingDTO>();

            gate.PutItems("api/Sortings/ ", sorting);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            DALServiceGateway<SortingDTO> gate = new DALServiceGateway<SortingDTO>();

            gate.DeleteItems("api/Sortings/" + id + "");
        }
    }
}
