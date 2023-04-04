using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDTrackingService.Models
{
    public class Area
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Zip { get; set; }
        public virtual List<Sorting> sortings { get; set; }
    }
}