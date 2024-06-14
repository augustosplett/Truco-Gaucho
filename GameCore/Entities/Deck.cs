namespace GameCore.Entities
{
    public class Deck : List<Card>
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Card GetRandomCard()
        {
            var CardsRemaining = Cards.Count;
            var rand = new Random();
            var randIndex = rand.Next(CardsRemaining);
            var card = Cards[randIndex];
            RemoveCard(card);
            return card;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }
    }
}
