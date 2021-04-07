using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomsApplication.Models
{
    public class HumanViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int RoomId { get; set; }
    }
}