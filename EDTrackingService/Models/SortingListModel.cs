using EDDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDTrackingService.Models
{
    public class SortingListModel
    {
        public IEnumerable<SortingDTO> sortings { get; set; }
    }
}