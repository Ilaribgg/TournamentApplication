using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TournamentApplication.Services;
using TournamentApplication.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TournamentApplication.Controllers
{
    [Route("api/Tournament")]
    [ApiController]
    public class TournamentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TournamentsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Tournament.ToListAsync() });
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var tournamentFromDb = _db.Tournament.FirstOrDefault(u => u.Id == id);
            if(tournamentFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
                _db.Tournament.Remove(tournamentFromDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "delete succesful" });

        }


    }
}
