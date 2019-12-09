using System;
using NinjaAssignment;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ninja Sam = new Ninja(); cannot make an object of an abstract class
            Buffet NinjaJoint = new Buffet();
            SweetTooth Scott = new SweetTooth();
            SpiceHound Jared = new SpiceHound();
            while(!Scott.IsFull)
            {
                Scott.Consume(NinjaJoint.Serve());
            }
            while(!Jared.IsFull)
            {
                Jared.Consume(NinjaJoint.Serve());
            }
            if(Scott.FoodHistory.Count > Jared.FoodHistory.Count)
            {
                Console.WriteLine($"SweetTooth consumed the most number of food items at {Scott.FoodHistory.Count}");
            } else
            {
                Console.WriteLine($"SpiceHound consumed the most number of food items at {Jared.FoodHistory.Count}");
            }
            // foreach(Food item in NinjaJoint.Menu)
            // {
            //     Console.WriteLine(item.Name);
            // }
            // Console.WriteLine(bacon.Name);
            // while(!Sam.IsFull)
            // {
            //     Sam.eat(NinjaJoint.Serve());
            // }
            string castSpell = Console.ReadLine();
            Console.WriteLine(castSpell + " has been cast!");
        }
    }
}
