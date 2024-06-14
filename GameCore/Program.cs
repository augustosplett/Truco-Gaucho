using GameCore.Entities;

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

var deck = new Deck { Cards = cards };

var player1 = new Player("Augusto");
Console.WriteLine(player1.ToString());
Console.WriteLine(deck.GetRandomCard());