using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.ContactDto;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.ContactDto;
using SignalRDtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        IMapper _mapper;
        IContactService _contactService;
        public ContactController(IContactService contactService,IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;   
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultContactDto>>(_contactService.GetAll());
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }


        [HttpGet("{id}")]
        public IActionResult GetListById(int id)
        {
            var result = _contactService.GetById(id);
            if (result != null)
            {
                var value = _mapper.Map<ResultContactDto>(result);
                return Ok(value);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactDto)
        {
            var value = _mapper.Map<Contact>(createContactDto); 
            _contactService.Add(value);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {

            var value = _mapper.Map<Contact>(updateContactDto);
            _contactService.Update(value);
            return Ok("About added successfully.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var result = _contactService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _contactService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
