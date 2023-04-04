using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EDDAL.Model;

namespace EDDAL.Repository.Imp
{
    public class SortingRepository :  ISortingRepository
    {
        System.Data.Entity.SqlServer.SqlProviderServices ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        EDTrackingServiceDBContext db = new EDTrackingServiceDBContext();

        public Sorting Add(Sorting sorting)
        {
            var s = db.Sorting.Add(sorting);
            db.SaveChanges();
            return s;
        }

        public Sorting Get(int id)
        {
            return db.Sorting.Find(id);
        }

        public IEnumerable<Sorting> GetAll()
        {
            return db.Sorting.ToList();
        }

        public IEnumerable<Sorting> getParcelByIdFromSorting(int parcelId)
        {
            return db.Sorting.Where(s => s.ParcelId == parcelId);
        }

        public void Remove(int id)
        {
            var so = db.Sorting.Single(s => s.Id == id);
            db.Sorting.Remove(so);
            db.SaveChanges();
        }

        public int Save(Sorting sorting)
        {
            Sorting s = db.Sorting.Add(sorting);
            db.SaveChanges();
            return s.Id;
        }

        public void Update(Sorting sorting)
        {
            var so = db.Sorting.Single(s => s.Id == sorting.Id);

            db.Sorting.Remove(so);
            db.Sorting.Add(sorting);
            db.SaveChanges();
        }
    }
}
