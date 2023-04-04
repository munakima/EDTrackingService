using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EDDAL.Model;

namespace EDDAL
{
   public class EDTrackingServiceDBContext: DbContext
    {
       
        public DbSet<Area> Areas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Sorting> Sorting { get; set; }
        public DbSet<Tracking> Tracking { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
    }
}
