using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentApplication.Models;
using TournamentApplication.Services;

namespace TournamentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        public GamesController(JsonFileGamesService gameService)
        {
            this.GamesService = gameService;
        }

        public JsonFileGamesService GamesService { get; }

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return GamesService.GetGames();
        }
    }
}
