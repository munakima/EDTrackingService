using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDTO
{
   public class AreaDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Zip { get; set; }

        public virtual IEnumerable<SortingDTO> sortings { get; set; }

    }
}
