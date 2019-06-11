using System;
using System.Collections.Generic;
namespace CardAssignment
{
    class Player
    {
        private string name;
        public List<Card> PlayerHand;

        public Player(string Name)
        {
            name = Name;
            PlayerHand = new List<Card>(); 
        }

        public Card DrawCard(Deck playDeck)
        {
            Card Drawn = playDeck.Draw();
            PlayerHand.Add(Drawn);
            return Drawn;
        }

        public void DrawHand(Deck playDeck)
        {
            for(int i = 0; i < 5; i++)
            {
                PlayerHand.Add(playDeck.Draw());
            }
        }

        public void Discard(Deck playDeck, int cardInHand)
        {
            if(cardInHand < PlayerHand.Count)
            {
                playDeck.DiscardPile.Add(PlayerHand[cardInHand]);
                Console.WriteLine("You have discarded the card " + PlayerHand[cardInHand].stringVal);
                PlayerHand.RemoveAt(cardInHand);
            } else
            {
                Console.WriteLine("You have no card to discard.");
            }
        }

        public void ShowHand()
        {
            foreach(Card card in PlayerHand)
            {
                Console.WriteLine("You have " + card.stringVal + " in your hand");
            }
        }
    }
}