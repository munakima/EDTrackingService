using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDTO
{
   public class SortingDTO
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ParcelId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? OutTime { get; set; }
        
        public virtual ParcelDTO parcel { get; set; }
        public virtual AreaDTO area { get; set; }
    }
}
