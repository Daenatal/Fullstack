using System;

namespace NinjaAssignment
{
    interface IConsumable 
    {
        string Name {get; set;}
        int Calories {get; set;}
        bool IsSpicy {get; set;}
        bool IsSweet {get; set;}
        string getInfo();
    }
    class Food: IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        //Foods can be spicy or sweet
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}
        public string getInfo()
        {
            return $"{Name} (Food). Calories: {Calories}. Spicy? {IsSpicy}, Sweet? {IsSweet}";
        }
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}