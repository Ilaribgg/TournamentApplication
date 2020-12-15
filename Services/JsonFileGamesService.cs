using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TournamentApplication.Models;
using Microsoft.AspNetCore.Hosting;

namespace TournamentApplication.Services
{
    public class JsonFileGamesService
    {
        public JsonFileGamesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "games.json"); }
        }
        private string JsonFileNameTournament
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "tournaments.json"); }
            set => Path.Combine(WebHostEnvironment.WebRootPath, "data", "tournaments.json");
        }
        private string JsonFileNamePlayer
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "players.json"); }
        }

        public IEnumerable<Game> GetGames()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Game[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public IEnumerable<Tournament> GetTournaments()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNameTournament))
            {
                return JsonSerializer.Deserialize<Tournament[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public IEnumerable<Player> GetPlayers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNamePlayer))
            {
                return JsonSerializer.Deserialize<Player[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}


    

