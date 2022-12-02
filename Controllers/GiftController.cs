using Microsoft.AspNetCore.Mvc;

namespace SantasWishlist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        public GiftController() { }

        [HttpGet]
        public IActionResult Get() => Ok();
    }
}