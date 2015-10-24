using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string roomNo { get; set; }
        public string roomName { get; set; }
        public string capacity { get; set; }
    }
}