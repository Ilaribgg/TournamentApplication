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
    public class TournamentsListModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public TournamentsListModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Tournament> Tournaments { get; set; }
        public async Task OnGet()
        {
            Tournaments = await _db.Tournament.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var tournament = await _db.Tournament.FindAsync(id);
            if(tournament == null)
            {
                return NotFound();
            }
            _db.Tournament.Remove(tournament);
            await _db.SaveChangesAsync();

            return RedirectToPage("Tournaments");
        }
    }
}
