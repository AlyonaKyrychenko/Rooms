using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Contracts
{
    public interface IHumanRepository
    {
        void Create(Human model);
        void Update(Human human);
        IReadOnlyCollection<Human> GetHumanByRoomId(int id);
        IReadOnlyCollection<Human> GetAll();
        Human GetById(int id);
    }
}
