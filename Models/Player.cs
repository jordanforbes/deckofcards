using System;
using System.Collections.Generic;
namespace DeckOfCards
{
    class Player
    {
        public string Name;

        List<Card> Hand = new List<Card>();

        public Deck PlayDeck = new Deck();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw()
        {
            Hand.Add(PlayDeck.Deal());
            ShowHand();
            return Hand[0];
        }

        public void ShowHand()
        {
            Console.WriteLine("your current hand is:");
            Hand.ForEach(delegate(Card name)
            {
                Console.WriteLine(name.StringVal);
            });
        }

        public Card Discard()
        {
            if(Hand[0] != null)
            {
                Card trashCard = Hand[0];
                Console.WriteLine(Hand[0].StringVal);
                Hand.RemoveAt(0);
                Console.WriteLine($"Discard {trashCard.StringVal}");
                return trashCard;
            }else{
                Console.WriteLine("null");
                return null;
            }
        }

    }
}