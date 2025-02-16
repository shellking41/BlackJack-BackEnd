using BlackJack.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameStateController : ControllerBase
    {
        private readonly IGameStateService _gameStateService;

        public GameStateController(IGameStateService gameStateService)
        {
            _gameStateService = gameStateService;
        }
        [HttpGet("{id}")]

        public IActionResult GetGameState([FromRoute]int id) 
        {
            return Ok(_gameStateService.GetGameState(id));
        }
        [HttpGet("GetGameStateByUserId/{id}")]
        public IActionResult GetGameStateByUserId([FromRoute] int id)
        {
            return Ok(_gameStateService.GetGameStateByUserId(id));
        }

        [HttpGet("GetAllGameStates")]
        public IActionResult GetAllGameStates()
        {
            return Ok(_gameStateService.GetAllGameStates());
        }
    }
}
