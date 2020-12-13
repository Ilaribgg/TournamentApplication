using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace TournamentApplication.Models
{
    public class Tournament : Game
    {
        public int TournamentId { get; set; }
        public string TournamentTitle { get; set; }
        public string TournamentInfo { get; set; }

    }
}
