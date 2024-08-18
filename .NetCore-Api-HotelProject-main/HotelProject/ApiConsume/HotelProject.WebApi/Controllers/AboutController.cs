using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.AboutDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(AddAboutRequest addAboutRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<About>(addAboutRequest);
            _aboutService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutRequest updateAboutRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<About>(updateAboutRequest);
            _aboutService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
