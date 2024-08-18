using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.GuestDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(CreateGuestRequest createGuestRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guest>(createGuestRequest);
            _guestService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetById(id);
            _guestService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(UpdateGuestRequest updateGuestRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guest>(updateGuestRequest);
            _guestService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.TGetById(id);
            return Ok(values);
        }
    }
}
