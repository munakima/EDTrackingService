using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Model
{
    public enum Status
    {
        SORTING, WAIT_DELIVERY, DELIVERY, COMPLETE
    }
    public class Parcel
        {
            public int Id { get; set; }
            public double Weight { get; set; }
            [DisplayFormat(NullDisplayText = "stateless")]
            public Status? Status { get; set; }
            public string RecevierName { get; set; }
            public string Address { get; set; }

            public virtual IEnumerable<Tracking> trackings { get; set; }
            public virtual IEnumerable<Sorting> sortings { get; set; }
        }
    
}
