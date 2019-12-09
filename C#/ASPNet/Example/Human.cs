using System;
namespace Example.Controllers
{
    class Human
    {
        private string name;
        private int health;
        private int strength;
        private int wisdom;

        public string Name
        {
            get {return name;}
        }
        public int Health
        {
            get{return health;}
        }
        public int Strength
        {
            get{return strength;}
        }
        public int Wisdom
        {
            get{return wisdom;}
        }
        
        public Human(string Name, int hp, int str, int wis)
        {
            name = Name;
            health = hp;
            strength = str;
            wisdom = wis;
        }

    }
}