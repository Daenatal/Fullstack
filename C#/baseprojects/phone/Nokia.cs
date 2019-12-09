using System;
namespace PhoneService
{
    class Nokia: Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringtone):base(versionNumber, batteryPercentage, carrier, ringtone)
        {
            isUnlocked = false;
        }

        private bool isUnlocked;
        private static string isSilent = ".......";

        public string Ring()
        {
            //shorthan if statement, if true return "brrzt.." if false then return isSilent variable
            return (isUnlocked) ? "Brrzt Brrzt Brrzt": isSilent;
        }
        public string Unlock()
        {
            isUnlocked = true;
            return "Phone unlocks using 4 digit passcode";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("###############################");
            Console.WriteLine($"Version Number: {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Phone Carrier: {Carrier}");
            Console.WriteLine($"Current Ringtone: {Ringtone}");
            Console.WriteLine("###############################");
            Console.WriteLine("");
        }

    }
}