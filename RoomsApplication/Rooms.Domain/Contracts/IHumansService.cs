using Rooms.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Contracts
{
    public interface IHumansService
    {
        void Create(HumanModel model);
        void AddHumanToRoom(int roomId, int humanId);
        IReadOnlyCollection<HumanModel> GetHumanByRoomId(int id);
        IReadOnlyCollection<HumanModel> GetAll();
    }
}
