using System;

namespace DeckOfCards {
    class Program {
        static void Main (string[] args) {
            // Deck testDeck = new Deck ();
            // testDeck.Deal ();
            // testDeck.Deal ();
            // testDeck.Reset ();
            // testDeck.Deal ();
            // testDeck.Shuffle();
            Player Jim = new Player("Jim");
            Jim.PlayDeck.Shuffle();
            Jim.Draw();
            Jim.Draw();
            Jim.Draw();
            Jim.Discard();
            Jim.Discard();
            Jim.Discard();
            Jim.Discard();
        }
    }
}