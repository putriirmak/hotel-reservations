using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class BedRoomType
    {
        public int Id { get; set; }
        public string bedRoomTypeCode { get; set; }
        public string bedRoomName { get; set; }
        public string imageBedroom { get; set; }
        public long sizeRoom { get; set; }

    }
}