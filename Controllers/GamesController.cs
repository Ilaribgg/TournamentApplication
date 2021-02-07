using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TournamentApplication.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace TournamentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public GamesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Game.ToListAsync() });
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var gameFromDb = _db.Game.FirstOrDefault(u => u.GameId == id);
            if (gameFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.Game.Remove(gameFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "delete succesful" });

        }

        private IActionResult Json(object p)
        {
            throw new NotImplementedException();
        }
    }
}
