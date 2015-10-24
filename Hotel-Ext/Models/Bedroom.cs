using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Bedroom
    {
        public int Id { get; set; }
        public string bedroomNumber { get; set; }
        public int availabilityStatus { get; set; }
        public BedRoomType bedroomType { get; set; }
    }
}