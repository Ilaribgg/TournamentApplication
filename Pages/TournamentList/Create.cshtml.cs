using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TournamentApplication.Models;

namespace TournamentApplication.Pages.TournamentList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Tournament Tournament { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Tournament.AddAsync(Tournament);
                await _db.SaveChangesAsync();
                return RedirectToPage("Tournaments");
            }
            else
            {
                return Page();
            }
        }
    }
}
