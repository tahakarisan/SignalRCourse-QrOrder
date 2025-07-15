using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.TestimonialDto;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<List<ResultCategoryDto>>(_categoryService.GetAll());
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.CategoryCount());
        }

        [HttpGet("activeCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_categoryService.ActiveCategoryCount());
        }

        [HttpGet("passiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_categoryService.PassiveCategoryCount());
        }

        [HttpGet("getCategoryCountByName")]
        public IActionResult CategoryCountByName(string name)
        {
            return Ok(_categoryService.GetCategoryByName(name));
        }

        [HttpPost]
        public IActionResult AddCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryService.Add(value);
            return Ok("About added successfully.");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.Update(value);
            return Ok("About added successfully.");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var result = _categoryService.GetById(id);
            if (result == null)
            {
                return BadRequest("Böyle Id yok");
            }
            _categoryService.Delete(result);
            return Ok("About deleted successfully.");
        }
    }
}
