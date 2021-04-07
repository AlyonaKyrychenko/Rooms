using Rooms.Data.Contracts;
using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Repositories
{
    public class HumanRepository : IHumanRepository
    {
        public void Create(Human model)
        {
            using (var ctx = new RoomsContext())
            {
                ctx.Humans.Add(model);

                ctx.SaveChanges();
            }
        }

        public void AddHumanToRoom(int roomId, int humanId)
        {
            using (var ctx = new RoomsContext())
            {
                var human = ctx.Humans.First(x => x.Id == humanId);

                human.RoomId = roomId;

                ctx.SaveChanges();
            }

        }

        public IReadOnlyCollection<Human> GetHumanByRoomId(int id)
        {
            using (var ctx = new RoomsContext())
            {
                return ctx.Humans.AsNoTracking().Where(x => x.RoomId == id).ToList();
            }
        }

        public IReadOnlyCollection<Human> GetAll()
        {
            using (var ctx = new RoomsContext())
            {
                return ctx.Humans.AsNoTracking().ToList();
            }
        }
    }
}
