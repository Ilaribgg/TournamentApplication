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
    public class TournamentsController : ControllerBase
    {
        public TournamentsController(JsonFileGamesService tournamentService)
        {
            this.TournamentsService = tournamentService;
        }
        public JsonFileGamesService TournamentsService { get; }

        [HttpGet]
        public IEnumerable<Tournament> Get()
        {
            return TournamentsService.GetTournaments();
        }
    }
}
