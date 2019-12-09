using System;
using PhoneService;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia elevenHundred = new Nokia("1100", 60, "T-Mobile", "Forty Days by Streelight Manifesto");
            Galaxy S8 = new Galaxy("S9+", 99, "Sprint", "Last Surprise");
            S8.DisplayInfo();
            Console.WriteLine(S8.Ring());
            Console.WriteLine(S8.Unlock());
            Console.WriteLine("");
            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(Ping.givePing());
        }
    }
}
