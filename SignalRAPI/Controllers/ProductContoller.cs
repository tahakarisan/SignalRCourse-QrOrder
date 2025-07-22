using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.ProductDto;
using SignalRDtoLayer.TestimonialDto;

namespace SignalRAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductContoller : Controller
    {
        IProductService _productService;
        IMapper _mapper; 
        public ProductContoller(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;   
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultProductDto>>(_productService.GetAll());
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("getProductWithCategory")]
        public IActionResult GetProductWithCategory()
        {
            var result = _mapper.Map<List<ResultProductWithCategoryDto>>(_productService.GetProductWithCategories());
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("getMaxPriceProduct")]
        public IActionResult GetMaxPrice()
        {
            var result = _productService.GetMaxPriceProduct();
            if (result!=null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("categoryCount")]
        public IActionResult CategoryCount()
        {
            var result = _productService.ProductCount();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result == null)
            {
                return NotFound("Böyle Id yok");
            }
            var value = _mapper.Map<ResultProductDto>(result);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            _productService.Add(value);
            return Ok("About added successfully.");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto);
            _productService.Update(value);
            return Ok("About added successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var result = _productService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _productService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
