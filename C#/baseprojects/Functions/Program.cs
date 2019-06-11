using System;
using System.Collections.Generic;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int IntegerValue = 65;
            //double DoubleValue = IntegerValue; //implicit type cast, works when getting more precise but not the other way

            double i = 3.14159265358;
            int i2 = (int)i; //explicit for precise to less precise
        
            int num = 7;
            //string numAsString = num.ToString();
            //double stringAsDouble = numAsString.ToDouble(); //convrts "7" to 7.0

            //Random Values

            Random rand = new Random();
            Console.WriteLine(rand.Next(2,4)); //this prints a random value between 2 and 4
        
            object BoxedData = "This is clearly a string";
            //Making sure this is the type we need before proceeding
            if (BoxedData is int) {
                //this shouldn't run
                Console.WriteLine("I don't think this is an int.");
            }
            if (BoxedData is string) {
                Console.WriteLine("It is definitely a string in the box!"); //is let's us discern the real type of an object, but we still need to cast it.
            }
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string; //as keyword lets us safe cast, only works for types which are nullable, won't work for ints.
        
            string greeting = SayHello("Bill");
            Console.WriteLine(greeting);
        }

        public static string SayHello(string firstName = "Horace"){

            return $"Hey {firstName}";
        }
    }
}
