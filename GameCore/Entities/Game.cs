namespace GameCore.Entities
{
    internal class Game
    {
        public int NumberOfPlayers { get; set; } = 2;
        public List<Player> Players { get; set; } = new List<Player>();

        public void StartNewGame()
        {
            //Create players the players Name
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Players.Add(CreatePlayer());
            }
            StartTurn();

            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine("Hand: ");
                foreach (Card card in player.Hand.Cards)
                {
                    Console.WriteLine(card);
                }
            }
        }
        private Player CreatePlayer()
        {
            string name;
            do
            {
                Console.Write("Enter Player Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            return new Player(name);
        }

        private void StartTurn()
        {
            
            List<Card> cards = new List<Card>()
            {
                new Card { FaceValue = "4",  RealValue = 4,  Suit = Suit.Heart },
                new Card { FaceValue = "5",  RealValue = 5,  Suit = Suit.Heart },
                new Card { FaceValue = "6",  RealValue = 6,  Suit = Suit.Heart },
                new Card { FaceValue = "7",  RealValue = 7,  Suit = Suit.Heart },
                new Card { FaceValue = "10", RealValue = 10, Suit = Suit.Heart },
                new Card { FaceValue = "11", RealValue = 11, Suit = Suit.Heart },
                new Card { FaceValue = "12", RealValue = 12, Suit = Suit.Heart },
                new Card { FaceValue = "1",  RealValue = 13, Suit = Suit.Heart },
                new Card { FaceValue = "2",  RealValue = 14, Suit = Suit.Heart },
                new Card { FaceValue = "3",  RealValue = 15, Suit = Suit.Heart },

                new Card { FaceValue = "4",  RealValue = 4,  Suit = Suit.Clubs },
                new Card { FaceValue = "5",  RealValue = 5,  Suit = Suit.Clubs },
                new Card { FaceValue = "6",  RealValue = 6,  Suit = Suit.Clubs },
                new Card { FaceValue = "7",  RealValue = 7,  Suit = Suit.Clubs },
                new Card { FaceValue = "10", RealValue = 10, Suit = Suit.Clubs },
                new Card { FaceValue = "11", RealValue = 11, Suit = Suit.Clubs },
                new Card { FaceValue = "12", RealValue = 14, Suit = Suit.Clubs },
                new Card { FaceValue = "1",  RealValue = 13, Suit = Suit.Clubs },
                new Card { FaceValue = "2",  RealValue = 14, Suit = Suit.Clubs },
                new Card { FaceValue = "3",  RealValue = 15, Suit = Suit.Clubs },

                new Card { FaceValue = "4",  RealValue = 4,  Suit = Suit.Diamond },
                new Card { FaceValue = "5",  RealValue = 5,  Suit = Suit.Diamond },
                new Card { FaceValue = "6",  RealValue = 6,  Suit = Suit.Diamond },
                new Card { FaceValue = "7",  RealValue = 16,  Suit = Suit.Diamond },
                new Card { FaceValue = "10", RealValue = 10, Suit = Suit.Diamond },
                new Card { FaceValue = "11", RealValue = 11, Suit = Suit.Diamond },
                new Card { FaceValue = "12", RealValue = 14, Suit = Suit.Diamond },
                new Card { FaceValue = "1",  RealValue = 13, Suit = Suit.Diamond },
                new Card { FaceValue = "2",  RealValue = 14, Suit = Suit.Diamond },
                new Card { FaceValue = "3",  RealValue = 15, Suit = Suit.Diamond },

                new Card { FaceValue = "4",  RealValue = 4,  Suit = Suit.Spades },
                new Card { FaceValue = "5",  RealValue = 5,  Suit = Suit.Spades },
                new Card { FaceValue = "6",  RealValue = 6,  Suit = Suit.Spades },
                new Card { FaceValue = "7",  RealValue = 17, Suit = Suit.Spades },
                new Card { FaceValue = "10", RealValue = 10, Suit = Suit.Spades },
                new Card { FaceValue = "11", RealValue = 11, Suit = Suit.Spades },
                new Card { FaceValue = "12", RealValue = 14, Suit = Suit.Spades },
                new Card { FaceValue = "1",  RealValue = 18, Suit = Suit.Spades },
                new Card { FaceValue = "2",  RealValue = 14, Suit = Suit.Spades },
                new Card { FaceValue = "3",  RealValue = 15, Suit = Suit.Spades }
            };

            var deck = new Deck { Cards = cards};

            for (int i = 0; i < 3; i++)
            {
                foreach (Player p in Players)
                {
                    p.Hand.AddCard(deck.GetRandomCard());
                }
            }
        }

    }
}
