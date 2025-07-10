using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.SocialMediaDto;
using SignalRDtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : Controller
    {
        ISocialMediaService _socialMediaService;
        IMapper _mapper; 
        public SocialMediaController(ISocialMediaService socialMediaService,IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper; 
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.GetAll());
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
            var result = _socialMediaService.GetById(id);
            if (result != null)
            {
                var value = _mapper.Map<ResultSocialMediaDto>(result);
                return Ok(value);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpPost]
        public IActionResult AddSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var result = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.Add(result);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialMediaDto); 
            _socialMediaService.Update(value);
            return Ok("About added successfully.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var result = _socialMediaService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _socialMediaService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
