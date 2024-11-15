using Microsoft.AspNetCore.Mvc;
namespace HorseRace.Controllers
{
    public class PlayingCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
