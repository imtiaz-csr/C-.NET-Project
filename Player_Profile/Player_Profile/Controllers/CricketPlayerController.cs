using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Player_Profile.Models;
using System.Threading.Tasks;

namespace Player_Profile.Controllers
{
    public class CricketPlayerController : Controller
    {
        private readonly PlayerDbContext Db;
        public CricketPlayerController(PlayerDbContext db)
        {
            Db = db;
        }
        public async Task<IActionResult> Index()
        {
            var listOfCricketPlayers = await Db.CricketPlayers.ToListAsync();
            return View(listOfCricketPlayers);
        }
    }
}
