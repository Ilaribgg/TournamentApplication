using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TournamentApplication.Models;

namespace TournamentApplication.Pages
{
    public class GamesModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public GamesModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Game> Games { get; set; }

        public async Task OnGet()
        {
            Games = await _db.Game.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteGame(int id)
        {
            var game = await _db.Game.FindAsync(id);
            if(game == null)
            {
                return NotFound();
            }
            _db.Game.Remove(game);
            await _db.SaveChangesAsync();

            return RedirectToPage("Games");
        }
    }
}
