using EDDAL;
using EDDAL.Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EDDAL_API.Controllers
{
    public class SortingsController : ApiController
    {
        DALFacade rep = new DALFacade();
        //IKernel _kernal = new StandardKernel(new DALModule());
        public SortingsController(){}
  
        public IEnumerable<Sorting> GetAllSortings(IEnumerable<Sorting> s)
        {
            return s;

        }
        public IEnumerable<Sorting> GetAllSortings()
        {
            return rep.getAllSortings();
        }
        // GET api/values
        public Sorting GetSingleSorting(int id)
        {
            var s = rep.getSingleSorting(id);

            if (s == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return s;
        }
        //public IEnumerable<Sorting> GetParcelFromSorting(int parcelId)
        //{
        //    return rep.GetParcelByIdFromSorting(parcelId);
        //}

        //[Route("Sortings/{parcelId}/parcels")]
        //[HttpGet]
        //public IEnumerable<Sorting> GetParcelFromSorting(int parcelId)
        //{
        //    return rep.GetParcelByIdFromSorting(parcelId);
        //}


        // POST api/values
        public HttpResponseMessage PostSorting(Sorting sorting)
        {

            sorting = rep.addSorting(sorting);
            var response = Request.CreateResponse<Sorting>(HttpStatusCode.Created, sorting);

            string uri = Url.Link("DefaultApi", new { id = sorting.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT api/values/5
        public void PutSoring(Sorting sorting)
        {
          
            rep.updateSorting(sorting);
        }

        // DELETE api/values/5
        public void DeleteSorting(int id)
        {
            rep.removeSorting(id);           
        }
    }
}
