using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.WorkLocationDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        private readonly IMapper _mapper;

        public WorkLocationController(IWorkLocationService workLocationService, IMapper mapper)
        {
            _workLocationService = workLocationService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(CreateWorkLocationRequest createWorkLocationRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<WorkLocation>(createWorkLocationRequest);
            _workLocationService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            _workLocationService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(UpdateWorkLocationRequest updateWorkLocationRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<WorkLocation>(updateWorkLocationRequest);
            _workLocationService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            return Ok(values);
        }
    }
}
