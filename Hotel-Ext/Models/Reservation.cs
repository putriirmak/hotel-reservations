using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string reservationNo { get; set; }
        public DateTime reservationStartDate { get; set; }
        public DateTime reservationEndDate { get; set; }
        public DateTime checkInTime { get; set; }
        public DateTime checkOutTime { get; set; }
        public List<Bedroom> bedrooms { get; set; }
        public UserHotel userHotel { get; set; }
    }
}