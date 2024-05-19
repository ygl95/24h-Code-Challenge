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


        /// <summary>
        /// Return list of current pizza products.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("products")]
        public async Task<ActionResult<List<PizzaType>>> Products()
        {
            return Ok(await _dataContext.PizzaTypes.Include(p => p.Pizzas).ToListAsync());
        }

        /// <summary>
        /// Return a filtered result base on 'order_id' from all orders.
        /// </summary>
        /// <param name="order_id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("orders/{order_id}")]
        public async Task<ActionResult> Orders(string order_id)
        {

            return Ok(await _dataContext.Sales.Where(i => i.OrderId.ToString().Equals(order_id)).ToListAsync());
        }

    }
}
