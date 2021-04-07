using AutoMapper;
using Rooms.Data.Contracts;
using Rooms.Data.Models;
using Rooms.Data.Repositories;
using Rooms.Domain.Contracts;
using Rooms.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Domain.Services
{
    public class RoomService : IRoomsService
    {
        private readonly IMapper _mapper;
        private readonly IRoomsRepository _roomsRepository;

        public RoomService()
        {
            _roomsRepository = new RoomsRepository();

            var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<RoomModel, Room>();
            });
            _mapper = new Mapper(config);
        }

        public void Create(RoomModel model)
        {
            var entity = _mapper.Map<Room>(model);

            _roomsRepository.Create(entity);
        }

        public IReadOnlyCollection<RoomModel> GetAll()
        {
            var rooms = _roomsRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<RoomModel>>(rooms);

            return result;
        }
    }
}
