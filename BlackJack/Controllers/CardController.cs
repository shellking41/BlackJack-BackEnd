using BlackJack.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{//itt hozzuk letre az endpointjainkat
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService testService)
        {
            _cardService = testService;
        }


        //public IActionResult Get([FromQuery]int Id) //Example : https://localhost:7253/api/Test?Id=5 
        //{

        //    return Ok(_cardService.GetCard(Id));

        //}
        //ez akkor kell ha FromRoute-t hasznalok
        [HttpGet("{Id}")]//Example : //https://localhost:7253/Card/5 
        public IActionResult GetCardById([FromRoute] int Id)
        {

            return Ok(_cardService.GetCard(Id));

        }
        [HttpGet("AllCards")]
        public IActionResult GetAllCards() //Example : https://localhost:7253/api/Card/AllCards
        {
            return Ok(_cardService.GetCards());
        }

        [HttpGet("GetCardsByUserId/{id}")]//Example : https://localhost:7253/api/Card/GetCardsByUserId/2

        public IActionResult GetCardsByUserId([FromRoute] int id) 
        {
            return Ok(_cardService.GetCardsByUserId(id));
        }
    }
}
