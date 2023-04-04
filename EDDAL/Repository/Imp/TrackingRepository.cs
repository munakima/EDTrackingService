using EDDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Repository.Imp
{
    public class TrackingRepository : ITrackingRepository
    {
        System.Data.Entity.SqlServer.SqlProviderServices ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        EDTrackingServiceDBContext db = new EDTrackingServiceDBContext();
        public Tracking Add(Tracking tracking)
        {
            var t = db.Tracking.Add(tracking);
            db.SaveChanges();
            return t;
        }

        public Tracking Get(int id)
        {
            return db.Tracking.Single(t => t.Id == id);
        }

        public IEnumerable<Tracking> GetAll()
        {
            return db.Tracking.ToList(); 
        }

     

        public void Remove(int id)
        {
            var tr = db.Tracking.Single(t => t.Id == id);
            db.Tracking.Remove(tr);
            db.SaveChanges();
        }

        public void Update(Tracking tracking)
        {
            var tr = db.Tracking.Single(t => t.Id == tracking.Id);

            db.Tracking.Remove(tr);
            db.Tracking.Add(tracking);
            db.SaveChanges();
        }
    }
}
