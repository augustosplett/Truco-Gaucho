namespace GameCore.Entities
{
    public class Cards
    {
        public List<Card> Deck { get; set; }

        public Card GetRandomCard()
        {
            var CardsRemaining = Deck.Count;
            var rand = new Random();
            var randIndex = rand.Next(CardsRemaining);
            var card = Deck[randIndex];
            return card;
        }

        private void RemoveCard()
        {
            var cardToRemove = Deck.FirstOrDefault();
        }
    }
}
