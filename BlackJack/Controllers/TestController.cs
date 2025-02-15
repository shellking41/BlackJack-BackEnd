using BlackJack.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{//itt hozzuk letre az endpointjainkat
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ICardService _CardService;

        public TestController(ICardService testService)
        {
            _CardService = testService;
        }
                    //ez akkor kell ha FromRoute-t hasznalok
        [HttpGet("Card/{Id}")]
        //public IActionResult Get([FromQuery]int Id) //https://localhost:7253/api/Test?Id=5 
        //{

        //    return Ok(_CardService.GetCard(Id));

        //}
        public IActionResult Get([FromRoute] int Id) //https://localhost:7253/Card/5 
        {

            return Ok(_CardService.GetCard(Id));

        }

    }
}
