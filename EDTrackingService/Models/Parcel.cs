using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDTrackingService.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int RecevierId { get; set; }
        public int SenderId { get; set; }
        public int StatusId { get; set; }

        public virtual Recevier recevier { get; set; }
        public virtual Sender sender { get; set; }
        public virtual Status status { get; set; }
        public virtual List<Sorting> sortings { get; set; }
    }
}