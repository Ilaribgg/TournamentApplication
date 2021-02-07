using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TournamentApplication.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Publisher { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
    }
}
