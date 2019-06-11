using System;

namespace NinjaAssignment
{
    class SweetTooth: Ninja
    {
        public int CalorieIntake 
        {
            get {return calorieIntake;}
        }
        public override bool IsFull
        {
            get {return calorieIntake > 1500;}
        }
        public override void Consume(IConsumable Item)
        {
            if(IsFull)
            {
                Console.WriteLine("Can't take another bite...");
                return;
            }
            
            Console.WriteLine($"SweetTooth is hungry and consumes a tasty {Item.Name}");
            if(Item.IsSweet == true)
            {
                calorieIntake += 10;
            }
            calorieIntake += Item.Calories;
            FoodHistory.Add(Item);
            Console.WriteLine(Item.getInfo());
        }
    }
}