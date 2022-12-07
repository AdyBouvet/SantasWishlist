using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace SantasWishlist.Controllers
{
    [ApiController]
    [Route("gifts")]
    public class GiftController : ControllerBase
    {
        public GiftController() { }

        [HttpGet]
        public IActionResult GetAll() => Ok();

        [HttpGet]
        [Route("/{id}")]
        public IActionResult Get(string id) => Ok();

        [HttpPost]
        public IActionResult Post([FromBody] string person) => Ok();

        [HttpDelete]
        [Route("/{id}")]
        public IActionResult Delete(string id) => Ok();
    }
}