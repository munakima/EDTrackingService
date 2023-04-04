using EDDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Repository
{
   public interface ISortingRepository
    {
         IEnumerable<Sorting> getParcelByIdFromSorting(int parcelId);
        IEnumerable<Sorting> GetAll();
        Sorting Get(int id);
        Sorting Add(Sorting sorting);
        void Update(Sorting sorting);
        void Remove(int id);
        int Save(Sorting sorting);
    }
}
