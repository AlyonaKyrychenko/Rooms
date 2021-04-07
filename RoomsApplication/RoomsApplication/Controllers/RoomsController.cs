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
    public class RoomsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRoomsService _roomService;

        public RoomsController()
        {
            _roomService = new RoomService(); 

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RoomModel, RoomViewModel>();
                cfg.CreateMap<RoomPostModel, RoomModel>();
                cfg.CreateMap<RoomViewModel, GetRoomViewModel>();
            });
            _mapper = new Mapper(config);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RoomPostModel model)
        {
            var createModel = _mapper.Map<RoomModel>(model);

            _roomService.Create(createModel);

            return new EmptyResult();
        }

        public ActionResult GetAll()
        {
            var rooms = _roomService.GetAll();
            var roomsVM = _mapper.Map<List<RoomViewModel>>(rooms);

            var result = new GetRoomViewModel
            {
                Rooms = roomsVM
            };

            return View(result);
        }
    }
}