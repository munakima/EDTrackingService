using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL.Model
{
    public class Area
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Zip { get; set; }

        public virtual IEnumerable<Sorting> sortings { get; set; }

    }
}
