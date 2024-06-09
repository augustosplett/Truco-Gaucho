// See https://aka.ms/new-console-template for more information
using GameCore.Entities;

var card1 = new Card { FaceValue = "A", RealValue = 13, Suit = Suit.Heart };
var card2 = new Card { FaceValue = "Q", RealValue = 10, Suit = Suit.Clubs };
var card3 = new Card { FaceValue = "K", RealValue = 9, Suit = Suit.Diamond };
List<Card> cards = new List<Card>();
cards.Add(card1);
cards.Add(card2);
cards.Add(card3);
var deck = new Cards { Deck = cards };

Console.WriteLine(deck.GetRandomCard());