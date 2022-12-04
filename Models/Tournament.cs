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
        [Required]
        public string TournamentInfo { get; set; }
        public string TournamentType { get; set; }
        public int PlayerAmount { get; set; }
        //public Game Game { get; set; }
        public string Title { get; set; }
    }

}
