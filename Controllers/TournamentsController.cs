using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TournamentApplication.Services;
using TournamentApplication.Models;

namespace TournamentApplication.Controllers
{
    [Route("api/Tournaments")]
    [ApiController]
    public class TournamentsController : ControllerBase
    {
        public TournamentsController(JsonFileGamesService tournamentService)
        {
            this.TournamentsService = tournamentService;
        }
        public JsonFileGamesService TournamentsService { get; set; }

        [HttpGet]
        public IEnumerable<Tournament> Get()
        {
            return TournamentsService.GetTournaments();
        }
        [HttpPost]
        public Tournament Index(Tournament tournament)
        {
            return tournament;
        }

    }
}
