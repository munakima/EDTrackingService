using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Model
{
   public class Delivery
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "getTime")]
        public DateTime getTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "CurrentTime")]
        public DateTime CurrentTime { get; set; }

        public string CurrrentLocation { get; set; }

        public IEnumerable<Tracking> tracking { get; set; }
        public Employee employee { get; set; }
    }
}
