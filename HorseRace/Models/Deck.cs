namespace HorseRace.Models
{
    public class Deck
    {
        public List<PlayingCard> Cards { get; set; } = new List<PlayingCard>();

        public Deck()
        {
            PopulateDeck();
        }
        private void PopulateDeck()
        {
            foreach (var suit in Enum.GetValues<Suits>())
            {
                foreach (var value in Enum.GetValues<Values>())

                    Cards.Add(new PlayingCard(value, suit));
            }
        }

        public PlayingCard DrawCard()
        {
            if (Cards.Count == 0)
                throw new InvalidOperationException("No cards left in the deck!");

            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                PlayingCard card = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = card;
            }
        }
    }
}
