using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EDDAL.Model;

namespace EDDAL
{
    public class EDTrackingServiceDBInitializer : CreateDatabaseIfNotExists<EDTrackingServiceDBContext>
    {
      
        protected override void Seed(EDTrackingServiceDBContext context)
        {
            
        }
    }
}
