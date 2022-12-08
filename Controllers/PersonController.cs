using Microsoft.AspNetCore.Mvc;
using SantasWishlist.Models.DTO;
using SantasWishlist.Repositories;
using SantasWishlist.Services;

namespace SantasWishlist.Controllers
{
    [ApiController]
    [Route("persons")]
    public class PersonController : ControllerBase
    {

        private readonly PersonService _service;

        public PersonController(PersonService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.ReadAll());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id) => Ok(_service.Read(id));

        [HttpPost]
        public IActionResult Post([FromBody] PersonDTO person) => Ok(_service.Create(person));

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}