using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDTO
{
    public class TrackingDTO
    {
        public int Id { get; set; }
        public int ParcelId { get; set; }
        public int DeliveryId { get; set; }

        public DateTime? CompleteTime { get; set; }
        public DeliveryDTO delivery { get; set; }
    }
}
