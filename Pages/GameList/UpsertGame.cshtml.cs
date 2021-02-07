using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TournamentApplication.Models;

namespace TournamentApplication.Pages.GameList
{
    public class UpsertGameModel : PageModel
    {
        private ApplicationDbContext _db;

        public UpsertGameModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Game Game { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            Game = new Game();
            if(id == null)
            {
                return Page();
            }
            Game = await _db.Game.FirstOrDefaultAsync(u => u.GameId == id);
            if(Game == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                if (Game.GameId == 0)
                {
                    _db.Game.Add(Game);
                }
                else
                {
                    _db.Game.Update(Game);
                }

                await _db.SaveChangesAsync();

                return RedirectToPage("Games");
            }

                return RedirectToPage();
        }
    }
}
