using System;
namespace CardAssignment
{
    class Card 
    {
        public string stringVal{get; set;}
        public string suitVal{get; set;}
        public int val{get; set;}

        public Card(string suit, int value)
        {
            suitVal = suit;
            val = value;
            if(value == 1) 
            {
                stringVal = "Ace of " + suit;
            } else if( value == 11) 
            {
                stringVal = "Jack of " + suit;
            } else if( value == 12) 
            {
                stringVal = "Queen of " + suit;
            } else if( value == 13) 
            {
                stringVal = "King of " + suit;
            } else 
            {
                stringVal = $"{value} of {suit}";
            }
        }

    }
}