using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;
using SignalRAPI.Models;
using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDtoLayer.BasketDto;
using SignalREntityLayer.Entities;
using System.Runtime.ConstrainedExecution;

namespace SignalRAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        IMapper _mapper;
        public BasketController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultBasketDto>>(_basketService.GetAll());
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
        public IActionResult AddBasket(CreateBasketDto createBasketDto)
        {
            var result = _mapper.Map<Basket>(createBasketDto);
            _basketService.Add(result);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult UpdateBasket(UpdateBasketDto updateBasketDto)
        {
            var result = _mapper.Map<Basket>(updateBasketDto);
            _basketService.Update(result);
            return Ok("About added successfully.");
        }
        [HttpDelete("DeleteBasket/{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var result = _basketService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _basketService.Delete(result);
            return Ok("About deleted successfully.");
        }

        [HttpGet("basketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            SignalRContext signalRContext = new SignalRContext();
            var values = signalRContext.Baskets.Include(c=>c.Product).Where(m=>m.MenuTableId==id).Select(z=>new ResultBasketListWithProducts
            {
                BasketId =z.BasketId,
                Price = z.Price,
                Count = z.Count,
                TotalPrice = z.Price*z.Count,
                ProductId = z.ProductId,
                ProductName = z.Product.Name,
                MenuTableId = z.MenuTableId,
                
            }).ToList();
            if (values.Count > 0)
            {
                return Ok(values);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values = _basketService.GetBasketByMenuTableNumber(id);
            return Ok(values);
        }

    }
}
