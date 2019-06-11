using System;
using System.Collections.Generic;
namespace CardAssignment
{
    class Deck
    {
        public List<Card> PlayerDeck;
        public List<Card> Backup;
        public List<Card> DiscardPile;
        
        public Deck()
        {
            PlayerDeck = new List<Card>();
            Backup = new List<Card>();
            DiscardPile = new List<Card>();
            for(int q = 1; q < 5; q++)
            {
                string suit;
                if( q == 1) 
                {
                    suit = "Clubs";
                } else if( q == 2)
                {
                    suit = "Spades";
                } else if( q == 3)
                {
                    suit = "Hearts";
                } else 
                {
                    suit = "Diamonds";
                }
                for(int i = 0; i < 13; i++)
                {
                    PlayerDeck.Add(new Card(suit, (i + 1)));
                    Backup.Add(new Card(suit, (i + 1)));
                };
            }
            
            
            
        }
        public Card Draw()
        {
            Card toHand = PlayerDeck[PlayerDeck.Count - 1];
            PlayerDeck.RemoveAt(PlayerDeck.Count -1);
            return toHand;
        }

        public List<Card> Reset()
        {
            return Backup;
        }

        public List<Card> Shuffle(List<Card> currentDeck)
        {
            List<Card> ShuffledDeck = new List<Card>();
            for(int i = 51; i > 0; i--)
            {
                Random rand = new Random();
                int random = rand.Next(currentDeck.Count);
                ShuffledDeck.Add(currentDeck[random]);
                currentDeck.RemoveAt(random);
            }
            ShuffledDeck.Add(currentDeck[0]);
            return ShuffledDeck;
        }
    }
}