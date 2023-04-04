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
    public class ParcelsController : ApiController
    {
        DALFacade dal = new DALFacade();
        public IEnumerable<Parcel> GetParcels()
        {
            return dal.getAllParcels();
        }
        public Parcel GetParcel(int id)
        {
            return dal.getSingleParcel(id);
        }
    }
}
