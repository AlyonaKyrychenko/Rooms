using Rooms.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Contracts
{
    public interface IRoomsService
    {
        IReadOnlyCollection<RoomModel> GetAll();
        void Create(RoomModel model);
    }
}
