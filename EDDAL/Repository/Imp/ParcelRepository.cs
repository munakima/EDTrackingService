using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDAL.Model;

namespace EDDAL.Repository.Imp
{
    public class ParcelRepository : IParcelRepository
    {
        EDTrackingServiceDBContext db = new EDTrackingServiceDBContext();
        public Parcel Get(int id)
        {
            return db.Parcels.Find(id);
        }

        public IEnumerable<Parcel> GetAll()
        {
            return db.Parcels.ToList();
        }
    }
}
