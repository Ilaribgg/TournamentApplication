using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TournamentApplication.Models;

namespace TournamentApplication.Pages.TournamentList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Tournament Tournament { get; set; }
        public async Task OnGet(int id)
        {
            Tournament = await _db.Tournament.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var TournamentFromdb = await _db.Tournament.FindAsync(Tournament.Id);
                TournamentFromdb.TournamentTitle = Tournament.TournamentTitle;
                TournamentFromdb.TournamentInfo = Tournament.TournamentInfo;
                TournamentFromdb.TournamentType = Tournament.TournamentType;
                TournamentFromdb.PlayerAmount = Tournament.PlayerAmount;

                await _db.SaveChangesAsync();

                return RedirectToPage("Tournaments");
            }
            return RedirectToPage();
        }
    }
}
