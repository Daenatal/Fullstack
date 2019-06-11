using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(3);
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} passengers.");
            myVehicle.MakeNoise("Tiboooooooo");
            myVehicle.CarDecal = "Stripes"; //we invoke the setter here, below we invoke the getter
            Console.WriteLine(myVehicle.CarDecal);
            myVehicle.Model = "Chevy";
            Console.WriteLine(myVehicle.Model);
        }
        
    }
    //include seperate from the Program class
    public class Vehicle
        {
            private string Decal;
            private int numPassengers; //defaults to 0
            public int NumPassengers{
                get { return numPassengers;}
            }
            public Vehicle(int val) //constructor doesn't need a return type or a access modifier
            {
                numPassengers = val;
            }

            public void MakeNoise(){
                Console.WriteLine("hooooot");
            }

            public void MakeNoise(string noise) //overloaded method
            {
                Console.WriteLine(noise);
            }

            public string CarDecal{
                get 
                {
                    return $"The car decal is going to be {Decal}";
                }
                set 
                {
                    Decal = value;
                }
            }

            public string Model{get; set;}
        }
}
