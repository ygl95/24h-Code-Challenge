using Microsoft.AspNetCore.Mvc;

namespace _24h_Code_Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzeriaAPIController : Controller
    {
        [HttpGet]
        [Route("previeworders/{order_id}")]
        public ActionResult Orders(string order_id)
        {

            return Ok(new { order_id });
        }

        [HttpGet]
        [Route("previewpizzas/{category}")]
        public ActionResult Pizzas(string category)
        {

            return Ok(new { category });
        }
    }
}
