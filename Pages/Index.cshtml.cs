using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentApplication.Models;
using TournamentApplication.Services;

namespace TournamentApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileGamesService GamesService;
        public IEnumerable<Game> Games { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileGamesService gamesService)
        {
            _logger = logger;
            GamesService = gamesService;
        }

        public void OnGet()
        {
            Games = GamesService.GetGames();
        }
    }
}
