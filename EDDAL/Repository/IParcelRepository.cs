using EDDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Repository
{
   public interface IParcelRepository
    {
        IEnumerable<Parcel> GetAll();
        Parcel Get(int id);
    }
}
