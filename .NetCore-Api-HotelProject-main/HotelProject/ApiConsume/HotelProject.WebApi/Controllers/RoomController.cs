using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(AddRoomRequest addRoomRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(addRoomRequest);
            _roomService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomRequest updateRoomRequest) 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomRequest);
            _roomService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id) 
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }
    }
}
