using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentApplication.Services;
using TournamentApplication.Models;

namespace TournamentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        public PlayersController(JsonFileGamesService playerService)
        {
            this.PlayersService = playerService;
        }
        public JsonFileGamesService PlayersService { get; }

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return PlayersService.GetPlayers();
        }
        [HttpPost]
        public Player Index (Player player)
        {
            return player;
        }
    }
}
