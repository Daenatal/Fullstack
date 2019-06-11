using System;

namespace NinjaAssignment
{
    class Drink: IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        //Foods can be spicy or sweet
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}
        public string getInfo()
        {
            return $"{Name} (Drink). Calories: {Calories}. Sweet? {IsSweet}";
        }

        public Drink(string name, int calories)
        {
            Name = name;
            Calories = calories;
            IsSpicy = false;
            IsSweet = true;
        }
    }
}