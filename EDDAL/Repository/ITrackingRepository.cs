using EDDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Repository
{
  public  interface ITrackingRepository
    {
        IEnumerable<Tracking> GetAll();
        Tracking Get(int id);
        Tracking Add(Tracking tracking);
        void Update(Tracking tracking);
        void Remove(int id);
    }
}
