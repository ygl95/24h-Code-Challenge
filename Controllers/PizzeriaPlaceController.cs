using _24h_Code_Challenge.Data;
using _24h_Code_Challenge.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace _24h_Code_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaPlaceController : ControllerBase
    {
        private readonly DataContext _dataContext;

        // Inject DbContext we careated for the pizza sales info
        public PizzaPlaceController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("products")]
        public async Task<ActionResult<List<PizzaType>>> Products()
        {
            return Ok(await _dataContext.PizzaTypes.Include(p => p.Pizzas).ToListAsync());
        }
    }
}
