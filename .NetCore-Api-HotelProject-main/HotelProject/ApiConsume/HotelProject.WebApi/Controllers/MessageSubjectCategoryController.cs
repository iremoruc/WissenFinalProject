using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.MessageSubjectCategoryDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageSubjectCategoryController : ControllerBase
    {
        private readonly IMessageSubjectCategoryService _messageSubjectCategoryService;
        private readonly IMapper _mapper;

        public MessageSubjectCategoryController(IMessageSubjectCategoryService messageSubjectCategoryService, IMapper mapper)
        {
            _messageSubjectCategoryService = messageSubjectCategoryService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult MessageSubjectCategoryList()
        {
            var values = _messageSubjectCategoryService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessageSubjectCategory(CreateMessageSubjectCategoryRequest createMessageSubjectCategoryRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<MessageSubjectCategory>(createMessageSubjectCategoryRequest);
            _messageSubjectCategoryService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessageSubjectCategory(int id)
        {
            var values = _messageSubjectCategoryService.TGetById(id);
            _messageSubjectCategoryService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageSubjectCategory(UpdateMessageSubjectCategoryRequest updateMessageSubjectCategoryRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<MessageSubjectCategory>(updateMessageSubjectCategoryRequest);
            _messageSubjectCategoryService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessageSubjectCategory(int id)
        {
            var values = _messageSubjectCategoryService.TGetById(id);
            return Ok(values);
        }
    }
}
