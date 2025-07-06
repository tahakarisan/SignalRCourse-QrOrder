using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;

namespace SignalRAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : Controller
    {
        IAboutService _aboutService;
        IMapper _mapper;
        public AboutController(IAboutService aboutService,IMapper mapper)
        {
            _mapper = mapper;
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultAboutDto>>(_aboutService.GetAll());   

            if(result.Count> 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpPost]
        public IActionResult AddAbout(CreateAboutDto createAboutDto)
        {
            var result = _mapper.Map<About>(createAboutDto);
            _aboutService.Add(result);  
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.Update(value);
            return Ok("About added successfully.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var result = _aboutService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _aboutService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
