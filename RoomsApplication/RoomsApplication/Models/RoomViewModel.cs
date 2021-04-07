using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomsApplication.Models
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int MaxHumanCount { get; set; }
    }
}