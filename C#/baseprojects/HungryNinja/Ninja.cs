using System;
using System.Collections.Generic;
namespace NinjaAssignment 
{
    abstract class Ninja 
    {
        protected int calorieIntake;
        public List<IConsumable> FoodHistory;

        // We can no longer instantiate objects of the abstract Ninja class
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get;}

        //We can no longer have code in our methods as it is an abstract class, can only contain the signature
        public abstract void Consume(IConsumable item);
        // {
        //     if(!IsFull)
        //     {
        //         calorieIntake += meal.Calories;
        //         FoodHistory.Add(meal);
        //         Console.WriteLine($"Ninja digs into the {meal.Name}, calories eaten are {calorieIntake}");
        //     }
        //     else 
        //     {
        //         Console.WriteLine("Ninja can't take another bite...");
        //     }
        //     return IsFull;
        // }
    }
}