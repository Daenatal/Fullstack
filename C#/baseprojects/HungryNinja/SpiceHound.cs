using System;
namespace NinjaAssignment
{
    class SpiceHound: Ninja
    {
        public int CalorieIntake 
        {
            get {return calorieIntake;}
        }
        public override bool IsFull
        {
            get {return calorieIntake > 1200;}
        }
        public override void Consume(IConsumable Item)
        {
            if(IsFull)
            {
                Console.WriteLine("Can't take another bite....");
                return;
            }
            
            Console.WriteLine($"SpiceHound is hungry and consumes a tasty {Item.Name}");
            if(Item.IsSpicy == true)
            {
                calorieIntake -= 5;
            }
            calorieIntake += Item.Calories;
            FoodHistory.Add(Item);
            Console.WriteLine(Item.getInfo());
        }
    }
}