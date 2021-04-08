using AutoMapper;
using Rooms.Domain.Contracts;
using Rooms.Domain.Models;
using Rooms.Domain.Services;
using RoomsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomsApplication.Controllers
{
    public class HumansController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHumansService _humanService;

        public HumansController()
        {
            _humanService = new HumanService();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HumanModel, HumanViewModel>();
                cfg.CreateMap<HumanPostModel, HumanModel>();
                cfg.CreateMap<HumanViewModel, GetHumanViewModel>();
            });
            _mapper = new Mapper(config);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HumanPostModel model)
        {
            var createModel = _mapper.Map<HumanModel>(model);

            _humanService.Create(createModel);

            return new EmptyResult();
        }

        public ActionResult Update()
        {
            return View();
        }

        [Route("Update/{id}")]
        [HttpPost]
        public ActionResult Update(int id, HumanPostModel model)
        {
            var updateModel = _mapper.Map<HumanModel>(model);
            _humanService.Update(id, updateModel);

            return new EmptyResult();
        }

        public ActionResult GetHumanByRoomId(int id)
        {
            var humans = _humanService.GetHumanByRoomId(id);
            var humansVM = _mapper.Map<List<HumanViewModel>>(humans);

            var result = new GetHumanViewModel
            {
                Humans = humansVM
            };

            return View(result);
        }

        public ActionResult GetAll()
        {
            var humans = _humanService.GetAll();
            var humansVM = _mapper.Map<List<HumanViewModel>>(humans);

            var result = new GetHumanViewModel
            {
                Humans = humansVM
            };

            return View(result);
        }
    }
}