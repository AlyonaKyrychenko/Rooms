using Rooms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Data.Contracts
{
    public interface IRoomsRepository
    {
        IReadOnlyCollection<Room> GetAll();
        void Create(Room model);
    }
}
