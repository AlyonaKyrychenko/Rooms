using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int MaxHumanCount { get; set; }

        public int HumanId { get; set; }
        public ICollection<Human> Humans { get; set; }
    }
}
