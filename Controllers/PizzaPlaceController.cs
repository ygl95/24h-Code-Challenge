using _24h_Code_Challenge.Data;
using _24h_Code_Challenge.Entities;
using _24h_Code_Challenge.Model;
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
        /// Return list of current pizza products and details.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("products/{type_id?}")]
        public async Task<ActionResult<List<PizzaType>>> Products(string type_id = "default")
        {
            try
            {
                if (!type_id.Equals("default"))
                {
                    return Ok(await _dataContext.PizzaTypes.Include(p => p.Pizzas).Where(t => t.PizzaTypeId.Equals(type_id)).ToListAsync());
                }
            }
            catch (Exception)
            {

                throw;
            }
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

        /// <summary>
        /// Return list of all pizza_type_id.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pizzatypes")]
        public async Task<ActionResult<List<PizzaVariance>>> PizzaTypes()
        {
            List<PizzaVariance> pizzaTypes = [];

            try
            {
                var pizza = await _dataContext.PizzaTypes.Select(p => new
                {
                    p.Name,
                    p.PizzaTypeId
                }).OrderBy(p => p.Name).ToListAsync();

                foreach (var item in pizza)
                {
                    pizzaTypes.Add(new PizzaVariance { Name = item.Name, TypeId = item.PizzaTypeId });
                }
            }
            catch (Exception)
            {

                throw;
            }

            return Ok(pizzaTypes);
        }

        /// <summary>
        /// return high to low selling pizzas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("bestselling")]
        public async Task<ActionResult> BestSelling()
        {            
            var res = await _dataContext.Sales.GroupBy(t => t.PizzaTypeId).Select(x => new
            {
                PizzaType = x.Key,
                TotalSales = x.Sum(y => y.Price)
            }).OrderByDescending(o => o.TotalSales).ToListAsync();
           
            return Ok(res);
        }
    }
}
