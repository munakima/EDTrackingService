using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL
{
   public static class DBInitializer
    { 
        public static void Initializer()
        {
            Database.SetInitializer(new EDTrackingServiceDBInitializer() );
        }
        
    }
}
