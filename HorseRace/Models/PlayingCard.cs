using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.WebUtilities;

namespace HorseRace.Models
{
    public class PlayingCard
    {
        [Range(2, 13)]
        public Values value { get; set; }
        public Suits Suit { get; set; }
    }

    /// <summary>
    /// Suits of Cards
    /// </summary>
    public enum Suits
    {
        Hearts = 1,
        Spades = 2,
        Diamonds = 3,
        Clubs = 4,
    }

    /// <summary>
    /// Values of Cards
    /// </summary>
    public enum Values
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen, 
        King,
    }
}
