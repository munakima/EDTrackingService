using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDTrackingService.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Area area { get; set; }
        public virtual List<Sorting> sortings { get; set; }
    }
}