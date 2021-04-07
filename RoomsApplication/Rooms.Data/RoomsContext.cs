using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data
{
    public class RoomsContext : DbContext
    {
        public RoomsContext() : base("DefaultConnection") { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Human> Humans { get; set; }

    }
}
