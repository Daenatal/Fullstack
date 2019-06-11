using System;
using CardAssignment;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the Deck

            Deck playingDeck = new Deck();

            // Checking to make sure the Deck was created properly

                // foreach(Card card in playingDeck.PlayerDeck)
                // {
                //     Console.WriteLine(card.stringVal);
                // }

            //Test the Draw method
            Card Hand = playingDeck.Draw();
            Console.WriteLine("You drew..." + Hand.stringVal);

            //Making sure Card was removed.
                // foreach(Card card in playingDeck.PlayerDeck)
                // {
                //     Console.WriteLine(card.stringVal);
                // }
                // foreach(Card card in playingDeck.Backup)
                // {
                //     Console.WriteLine(card.stringVal);
                // }

            //Testing the Reset method
            playingDeck.PlayerDeck = playingDeck.Reset();

            // Console.WriteLine("player deck has been reset");
            // foreach(Card card in playingDeck.PlayerDeck)
            // {
            //     Console.WriteLine(card.stringVal);
            // }

            //Testing the shuffle method a few times 

            Console.WriteLine("player deck will now be shuffled!!");
            playingDeck.PlayerDeck = playingDeck.Shuffle(playingDeck.PlayerDeck);
            // foreach(Card card in playingDeck.PlayerDeck)
            // {
            //     Console.WriteLine(card.stringVal);
            // }
            Console.WriteLine("player deck will now be shuffled again!!");
            playingDeck.PlayerDeck = playingDeck.Shuffle(playingDeck.PlayerDeck);
            // foreach(Card card in playingDeck.PlayerDeck)
            // {
            //     Console.WriteLine(card.stringVal);
            // }

            Console.WriteLine("player deck will now be shuffled again!!");
            playingDeck.PlayerDeck = playingDeck.Shuffle(playingDeck.PlayerDeck);
            // foreach(Card card in playingDeck.PlayerDeck)
            // {
            //     Console.WriteLine(card.stringVal);
            // }

            //Creating the Player
            Player Jesus = new Player("Jesus");

            //Grabbing 5 cards from the deck
            Jesus.DrawHand(playingDeck);
            Jesus.ShowHand();

            Jesus.Discard(playingDeck, 2);
            Jesus.Discard(playingDeck, 5);
            Jesus.DrawCard(playingDeck);
            Jesus.ShowHand();

        }
    }
}
