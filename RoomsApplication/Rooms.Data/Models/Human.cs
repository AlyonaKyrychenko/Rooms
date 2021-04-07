using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public int RoomId { get; set; }
        public Room Rooms { get; set; }
    }
}
