using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : Controller
    {
        ITestimonialService _testimonialService;
        IMapper _mapper;


        public TestimonialController(ITestimonialService testimonialService,IMapper mapper)
        {
            _mapper = mapper;
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.GetAll());
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpPost]
        public IActionResult AddTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.Add(value);
            return Ok("About added successfully.");
        }
        [HttpDelete]
        public IActionResult UpdateTestimonial(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<Testimonial>(updateAboutDto);   
            _testimonialService.Update(value);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult DeleteTestimonial(int id)
        {
            var result = _testimonialService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _testimonialService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
