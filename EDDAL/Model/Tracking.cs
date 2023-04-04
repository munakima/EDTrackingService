using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Model
{
    public class Tracking
    {
        public int Id { get; set; }
        public int ParcelId { get; set; }
        public int DeliveryId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CompleteTime")]
        public DateTime? CompleteTime { get; set; }

        public Delivery delivery { get; set; }
        public Parcel parcel { get; set; }
    }
}
