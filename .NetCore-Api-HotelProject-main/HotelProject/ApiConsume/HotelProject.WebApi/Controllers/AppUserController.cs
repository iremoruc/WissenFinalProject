using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DtoLayer.Dtos.AppUserDto.Requests;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AppUserController(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;

        }
        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
        [HttpGet]
        public IActionResult AppUserListWithWorkLocation()
        {
            var values = _appUserService.TGetUserListWithWorkLocation();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAppUser(CreateAppUserRequest createAppUserRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<AppUser>(createAppUserRequest);
            _appUserService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAppUser(int id)
        {
            var values = _appUserService.TGetById(id);
            _appUserService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAppUser(UpdateAppUserRequest updateAppUserRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<AppUser>(updateAppUserRequest);
            _appUserService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetAppUser(int id)
        {
            var values = _appUserService.TGetById(id);
            return Ok(values);
        }
    }
}
