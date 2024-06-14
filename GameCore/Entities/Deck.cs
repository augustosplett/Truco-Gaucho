namespace GameCore.Entities
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Card GetRandomCard()
        {
            var CardsRemaining = Cards.Count;
            var rand = new Random();
            var randIndex = rand.Next(CardsRemaining);
            var card = Cards[randIndex];
            RemoveCard(card);
            return card;
        }

        public void AddCard( Card card)
        {
            Cards.Add(card);
        }

        private void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }
    }
}
