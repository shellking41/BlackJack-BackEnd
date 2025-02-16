using BlackJack.Models;
using BlackJack.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        [HttpGet("{id}")]
        public IActionResult GetStatistic(int id) 
        {
            return Ok(_statisticService.GetStatistic(id));
        }
        [HttpGet("GetStatisticByUserId/{id}")]
        public IActionResult GetStatisticByUserId(int id)
        {
            return Ok(_statisticService.GetStatisticByUserId(id));
        }
        [HttpGet("GetAllStatistics")]
        public IActionResult GetAllStatistics()
        {
            return Ok(_statisticService.GetAllStatistics());
        }
    }
}
