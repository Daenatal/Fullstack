using System;
using System.Collections.Generic;
namespace NinjaAssignment
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pancakes", 800, false, true),
                new Food("Hotdog", 400, false, false),
                new Food("Chicken Soup", 500, false, false),
                new Food("Hamburger", 900, false, false),
                new Food("Pasta", 800, false, false),
                new Food("Burrito", 1100, false, false),
                new Food("Chili", 700, true, false),
                new Drink("Sweet Tea", 300),
                new Drink("Milk", 280),
                new Drink("Coke", 360),
                new Drink("Orange Juice", 340)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
            
        }
    }
}