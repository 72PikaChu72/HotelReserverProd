﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReserver.Classes
{
    public class Room
    {
        public int Number { get; set; }
        public string GuestFIO { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string RoomType { get; set; }
    }
}
