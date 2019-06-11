using System;

namespace HumanAssignment 
{
    class Human 
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Agility;
        protected int health;

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Agility = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int agi, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Agility = agi;
            health = hp;
        }
        public int Health 
        {
            get {return health;}
            set {health = value;}
        }

        public void Stats()
        {
            Console.WriteLine($"Hello {Name}, your stats are as follows: Health - {Health} Strength - {Strength} Intelligence - {Intelligence} Dexterity - {Dexterity} Agility - {Agility}");
        }

        public virtual void Attack(Human target)
        {
            int attack  = Strength * 5;
            target.Health -= attack;
            this.Action(attack, target);
        }
        public void Action(int damage, Human target)
        {
            Console.WriteLine($"{Name} attacks and deals {damage} damage!");
            if(target.health < 0)
            {
                Console.WriteLine($"{target.Name} enemy has been defeated!");
            }
            else
            {
                Console.WriteLine($"{target.Name} has {target.health} remaining");
            }
        }
    }
    //Defining a child of the human class
    class Wizard: Human
    {
        public Wizard(string name):base(name)
        {
            Name = name;
            Strength = 4;
            Intelligence = 25;
            Dexterity = 8;
            Agility = 8;
            health = 50;
        }
        public override void Attack(Human target)
        {
            int TargetHealth = target.Health;
            int damage = Intelligence * 5;
            int newHealth = TargetHealth - damage;
            target.Health = newHealth;
            Health += damage;
            this.Action(damage, target);
        }
        public void Heal(Human target)
        {
            int healAmt = Intelligence;
            target.Health += healAmt;
            Console.WriteLine($"{Name} heals {target.Name} for {healAmt}!");
        }
    }
    class Ninja: Human
    {
        public Ninja(string name):base(name)
        {
            Name = name;
            Strength = 8;
            Intelligence = 7;
            Dexterity = 175;
            Agility = 177;
            health = 100;
        }
        public override void Attack(Human target)
        {
            int TargetHealth = target.Health;
            int damage = Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(10) < 3)
            {
                Console.WriteLine("Scored an extra hit! Enemy took an extra 10 damage");
                target.Health -= 10;
            }
            int newHealth = TargetHealth - damage;
            target.Health = newHealth;
            this.Action(damage, target);
        }
        public void Siphon(Human target)
        {
            target.Health -= 5;
            this.Health += 5;
            Console.WriteLine($"{this.Name} throws a life draining seal onto {target.Name} and drains its health leaving it with {target.Health}");
        }
    }
    class Samurai: Human
    {
        public Samurai(string name):base(name)
        {
            Name = name;
            Strength = 180;
            Intelligence = 5;
            Dexterity = 70;
            Agility = 100;
            health = 200;
        }
        public override void Attack(Human target)
        {
            int TargetHealth = target.Health;
            int damage = Strength * 5;
            if(TargetHealth < 50)
            {
                Console.WriteLine("Opponent is low on health, "+ Name + " activates execute ability!");
                Console.WriteLine($"{Name} performs a quick dash past the {target.Name}, it collapses as a lifeless husk on the ground.");
                target.Health = 0;
                return;
            }
            int newHealth = TargetHealth - damage;
            target.Health = newHealth;
            this.Action(damage, target);
        }
        public void Meditate()
        {
            this.Health = 200;
            Console.WriteLine($"{this.Name} channels their inner strength to heal all damage!");
        }
    }
}