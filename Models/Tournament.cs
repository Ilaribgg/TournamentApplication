using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace TournamentApplication.Models
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TournamentTitle { get; set; }
        public string TournamentInfo { get; set; }

        //public override string ToString() => JsonSerializer.Serialize<Tournament>(this);
    }
}
