using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDTO
{
   public class DeliveryDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public DateTime getTime { get; set; }

        public DateTime CurrentTime { get; set; }
        public string CurrrentLocation { get; set; }

        public IEnumerable< TrackingDTO> tracking { get; set; }
        public EmployeeDTO empolyee { get; set; }
    }
}
