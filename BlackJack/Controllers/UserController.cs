using BlackJack.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet("{id}")] //Example : https://localhost:7253/api/User/id
        public IActionResult GetUser([FromRoute] int id) 
        { 
            return Ok(_service.GetUser(id));
        }
        [HttpGet("AllUsers")] //Example : https://localhost:7253/api/User/AllUsers
        public IActionResult GetUsers()
        {
            return Ok(_service.GetUsers());
        }
    }
}
