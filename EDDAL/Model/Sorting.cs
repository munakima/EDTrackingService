using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Model
{
    public class Sorting
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ParcelId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "EntryTime")]
        public DateTime EntryTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "OutTime")]
        public DateTime? OutTime { get; set; }

        public virtual Parcel parcel { get; set; }
        public virtual Area area { get; set; }
    }
}
