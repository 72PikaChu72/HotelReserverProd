using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserver.Classes
{
    public class Booking
    {
        public int id { get; set; }
        public string RoomType { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set;}
        public string BookerFIO { get; set; }
        public string Note {get; set;}
        public string Status { get; set;}
    }
}
