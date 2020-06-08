using System;
using System.Collections.Generic;

namespace DeckOfCards {
    class Deck {
        public List<Card> cards = new List<Card> ();
        
        public void Reset()
        {
            cards.Clear();
            MakeDeck();
        }
        //deck
        public Deck () {
            MakeDeck();
        }
        public void MakeDeck()
        {

            string[] suitArr = { "Spades","Clubs","Hearts","Diamonds"};
            for(int j = 0; j < 4; j++)
            { 
            for (int i = 1; i < 13; i++) {
                    string suit = suitArr[j];
                    if (i == 1) {
                        cards.Add (new Card ($"Ace of {suit}", suit, i));
                    } else if (i == 11) {
                        cards.Add (new Card ($"Jack of {suit}", suit, i));
                    } else if (i == 12) {
                        cards.Add (new Card ($"Queen of {suit}", suit, i));
                    } else if (i == 13) {
                        cards.Add (new Card ($"King of {suit}", suit, i));
                    } else {
                        cards.Add (new Card ($"{i} of {suit}", suit, i));
                    }

                }

                }
                ListDeck();
            }
            public void ListDeck(){

                cards.ForEach(delegate(Card name)
                {
                    Console.WriteLine(name.StringVal);
                });
            }
            //end deck
            public Card Deal()
            {
                Card topCard = cards[0];
                cards.RemoveAt(0);
                Console.WriteLine($"the top card is the {topCard.StringVal}");
                return topCard;
            }

            public void Shuffle(){
                Random rand = new Random();
                int i = cards.Count;
                while(i > 1)
                {
                    i --;
                    int rng = rand.Next(i + 1);
                    Card aCard = cards[rng];
                    cards[rng] = cards[i];
                    cards[i] = aCard;
                }
                ListDeck();
            }
            
        }
    }

