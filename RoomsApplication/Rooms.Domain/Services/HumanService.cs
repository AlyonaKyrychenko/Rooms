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
    public class HumanService : IHumansService
    {
        private readonly IMapper _mapper;
        private readonly IHumanRepository _humansRepository;

        public HumanService()
        {
            _humansRepository = new HumanRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Human, HumanModel>();
                cfg.CreateMap<HumanModel, Human>();
            });
            _mapper = new Mapper(config);
        }

        public void Create(HumanModel model)
        {
            var entity = _mapper.Map<Human>(model);

            _humansRepository.Create(entity);
        }

        public void AddHumanToRoom(int roomId, int humanId)
        {
            _humansRepository.AddHumanToRoom(roomId, humanId);
        }

        public IReadOnlyCollection<HumanModel> GetHumanByRoomId(int id)
        {
            var humans = _humansRepository.GetHumanByRoomId(id);
            var result = _mapper.Map<IReadOnlyCollection<HumanModel>>(humans);

            return result;
        }

        public IReadOnlyCollection<HumanModel> GetAll()
        {
            var humans = _humansRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<HumanModel>>(humans);

            return result;
        }
    }
}
