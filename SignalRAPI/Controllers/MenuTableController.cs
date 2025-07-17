using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : Controller
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTableController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _menuTableService.GetAll();
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("No records found.");
            }
        }

        [HttpGet("TableCount")]
        public IActionResult TableCount()
        {
            return Ok(_menuTableService.TableCount());
        }

        [HttpGet("{id}")]
        public IActionResult ListById(int id)
        {
            return Ok(_menuTableService.GetById(id));
        } 

        [HttpPost]
        public IActionResult AddTable(MenuTable menuTable)
        {
            _menuTableService.Add(menuTable);
            return Ok("Table added successfully.");
        }

        [HttpPut]
        public IActionResult UpdateTable(MenuTable menuTable)
        {
            _menuTableService.Update(menuTable);
            return Ok("Table updated successfully.");
        }

        [HttpPut("UpdateStatus/{tableName}")]
        public IActionResult UpdateStatus(string tableName)
        {
            _menuTableService.UpdateStatus(tableName);
            return Ok("Table status updated successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTable(int id)
        {
            var table = _menuTableService.GetById(id);
            if (table != null)
            {
                _menuTableService.Delete(table);
                return Ok("Table deleted successfully.");
            }
            else
            {
                return NotFound("Table not found.");
            }
        }

    }
}
