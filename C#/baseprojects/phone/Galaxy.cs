using System;
namespace PhoneService
{
    class Galaxy: Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringtone):base(versionNumber, batteryPercentage, carrier, ringtone){}

        public string Ring()
        {
            return "Dinnnnng....Dinnnnng...Dinnnnng";
        }
        public string Unlock()
        {
            return "Phone unlocks using thumbprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Version Number: {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Phone Carrier: {Carrier}");
            Console.WriteLine($"Current Ringtone: {Ringtone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("");
        }

    }
}