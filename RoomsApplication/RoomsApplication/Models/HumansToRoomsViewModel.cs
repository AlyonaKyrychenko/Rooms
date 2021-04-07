using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomsApplication.Models
{
    public class HumansToRoomsViewModel
    {
        public int HumanId { get; set; }
        public List<HumanViewModel> Humans { get; set; }

        public int RoomId { get; set; }
        public List<RoomViewModel> Rooms { get; set; }
    }
}