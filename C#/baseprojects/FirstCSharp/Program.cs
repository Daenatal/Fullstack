using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int u = 1;
            // while (u <= 255) {
            //     Console.WriteLine(u);
            //     u++;
            // }
            // for(int i = 1; i <=100; i++) {
            //     if((i % 3) == 0 && (i % 5) == 0){ 
            //         Console.WriteLine("FizzBuzz " + i);
            //     } else if((i % 3) == 0 && (i % 5) != 0 ){
            //         Console.WriteLine("Fizz " + i);
            //     } else if ((i % 5) == 0 && (i % 3) != 0){
            //         Console.WriteLine("Buzz " + i);
            //     }
            // }
            int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(numArray[9]);
            string[] nameArray;
            nameArray = new string[] {"Tim", "Martin", "Nick", "Sara"};
            Console.WriteLine(nameArray[2]);
            bool[] testArray = new bool[10];
            for(int i = 0; i< testArray.Length; i++) {
                testArray[i] = true;
                if(i > 0 && ((i+1) % 2) == 0) {
                    testArray[i] = false;
                }
                Console.WriteLine("The value at " + i + " is " +testArray[i]);
            } 
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Coffee");
            flavors.Add("Mint");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            Dictionary<string, string> flavorPicks = new Dictionary<string, string>();
            flavorPicks.Add(nameArray[0], flavors[0]);
            flavorPicks.Add(nameArray[1], flavors[1]);
            flavorPicks.Add(nameArray[2], flavors[2]);
            flavorPicks.Add(nameArray[3], flavors[3]);
            foreach (var flavorPick in flavorPicks){
                Console.WriteLine($"{flavorPick.Key}'s favorite icecream flavor is {flavorPick.Value}!");
            }
            int[,] multiArray = new int[4,3] { {3,0,5}, {45, 9, 20}, {3, 20, 15}, {99, 55, 11}};
            Console.WriteLine(multiArray[1,2]);
        }
    }
}
