using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDTO
{
    public enum Status
    {
        SORTING, WAIT_DELIVERY, DELIVERY, COMPLETE
    }
    public class ParcelDTO
    {

        public int Id { get; set; }
        public double Weight { get; set; }
        public Status? Status { get; set; }
        public string RecevierName { get; set; }
        public string Address { get; set; }

        public virtual IEnumerable<TrackingDTO> trackings { get; set; }
        public virtual IEnumerable<SortingDTO> sortings { get; set; }
    }
}
