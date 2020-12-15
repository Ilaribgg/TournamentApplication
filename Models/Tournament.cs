using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace TournamentApplication.Models
{
    public class Tournament
    {
        //public long id { get; set; }
        public string TournamentTitle { get; set; }
        public string TournamentInfo { get; set; }

        //public override string ToString() => JsonSerializer.Serialize<Tournament>(this);
    }
}
