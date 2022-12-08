using Microsoft.AspNetCore.Mvc;
using SantasWishlist.Models;
using SantasWishlist.Repositories;

namespace SantasWishlist.Controllers
{
    [ApiController]
    [Route("gifts")]
    public class GiftController : ControllerBase
    {

        private readonly PersonRepository _repo;

        public GiftController(PersonRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repo.ReadAll());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id) => Ok(_repo.Read(id));

        [HttpPost]
        public IActionResult Post([FromBody] Person person) => Ok(_repo.Create(person));

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            _repo.Delete(id);
            return Ok();
        }
    }
}