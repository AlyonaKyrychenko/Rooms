using Rooms.Data.Contracts;
using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Repositories
{
    public class RoomsRepository : IRoomsRepository
    {
        public void Create(Room model)
        {
            using (var ctx = new RoomsContext())
            {
                ctx.Rooms.Add(model);

                ctx.SaveChanges();
            }
        }

        public IReadOnlyCollection<Room> GetAll()
        {
            using (var ctx = new RoomsContext())
            {
                return ctx.Rooms.AsNoTracking().ToList();
            }
        }
    }
}
