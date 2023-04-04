using EDDAL.Repository;
using EDDAL.Repository.Imp;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL
{
   public class DALModule:NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<ISortingRepository>().To<SortingRepository>();
            this.Kernel.Bind<ITrackingRepository>().To<TrackingRepository>();
            this.Kernel.Bind<IParcelRepository>().To<ParcelRepository>();

        }


    }
}
