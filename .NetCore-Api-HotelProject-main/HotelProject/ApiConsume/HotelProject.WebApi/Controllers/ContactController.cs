using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.ContactDto.Requests;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService ContactService, IMapper mapper)
        {
            _contactService = ContactService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(CreateContactRequest createContactRequest)
        {
            createContactRequest.Date = Convert.ToDateTime(DateTime.Now.ToString());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Contact>(createContactRequest);
            _contactService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactRequest updateContactRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Contact>(updateContactRequest);
            _contactService.TUpdate(values);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_contactService.TGetContactCount());
        }
    }
}
