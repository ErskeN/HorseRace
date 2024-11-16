//Player.cs (i Models-mappen)
using HorseRace.Models;
using Microsoft.AspNetCore.Mvc;

namespace HorseRace.Models
{
	public enum Suit
	{
		Spades,    // ♠
		Diamonds,  // ♦
		Clubs,     // ♣
		Hearts     // ♥
	}
	public class Player
    {
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}

//PlayingCardController.cs
namespace HorseRace.Controllers
{
    public class PlayingCardController : Controller
    {
        public Deck CardDeck { get; set; } = new Deck();
        public List<Player> Players { get; set; } = new List<Player>();

        public IActionResult Index()
        {
            return View(CardDeck);
        }

        public IActionResult AddPlayer(string playerName)
        {
            if (!string.IsNullOrEmpty(playerName))
            {
                Players.Add(new Player(playerName));
                TempData["Message"] = $"Spelare {playerName} har lagts till!";
            }
            return RedirectToAction("Index");
        }

        public IActionResult GetPlayers()
        {
            return View(Players);
        }
    }
}