using System;
using HumanAssignment;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Fred = new Human("Fred");
            Fred.Stats();
            Human Target = new Human("Target Dummy");
            Human Sieg = new Human("Seigfried", 50, 17, 30, 35, 2000);
            // Sieg.Stats();
            Fred.Attack(Target);
            // Target.Stats();
            // Fred.Attack(Target);
            // Fred.Attack(Target);
            // Target.Stats();
            // Console.WriteLine("Fred unleashes a flurry of attacks on the poor defenseless Target Dummy");
            // Fred.Attack(Target);
            // Fred.Attack(Target);
            // Fred.Attack(Target);
            // Fred.Attack(Target);
            Wizard Yir = new Wizard("Yir");
            Yir.Stats();
            //Yir.Attack(Target);
            Ninja Shiza = new Ninja("Shiza");
            Shiza.Stats();
            //Shiza.Attack(Target);
            Samurai Jack  = new Samurai("Jack");
            Jack.Stats();
            Fred.Attack(Target);
            Fred.Attack(Target);
            Fred.Attack(Target);
            //Jack.Attack(Target);
            Yir.Heal(Target);
            Target.Stats();
            Target.Attack(Jack);
            Jack.Meditate();
            Jack.Stats();
            Shiza.Siphon(Target);
        }
    }
}
