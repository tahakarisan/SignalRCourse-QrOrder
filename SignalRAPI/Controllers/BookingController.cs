using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.TestimonialDto;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        IBookingService _bookingService;
        IMapper _mapper;
        public BookingController(IBookingService bookingService,IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultBookingDto>>(_bookingService.GetAll());
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
        public IActionResult AddBooking(CreateBookingDto createBookingDto)
        {
            var result = _mapper.Map<Booking>(createBookingDto);
            _bookingService.Add(result);
            return Ok("About added successfully.");
        }
        [HttpDelete]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var result = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.Update(result);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult DeleteAbout(int id)
        {
            var result = _bookingService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _bookingService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
