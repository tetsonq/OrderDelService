using Microsoft.AspNetCore.Mvc;

namespace DeliveryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Delivery service is up!");
        }
    }
}