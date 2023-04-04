using EDDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EDTrackingService.Models
{
    public class Sorting
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int ParcelId { get; set; }
        public int AreaId { get; set; }
        public DateTime EntryTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? DeliveryTime { get; set; }

        public virtual Warehouse warehouse { get; set; }
        public virtual Parcel parcel { get; set; }
        public virtual Area area { get; set; }

    }
}