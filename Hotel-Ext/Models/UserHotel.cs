﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class UserHotel
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public long phoneNumber { get; set; }
    }
}