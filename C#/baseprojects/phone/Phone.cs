using System;
namespace PhoneService
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringtone;

        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringtone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringtone = ringtone;
        }

        //abstract method to be implemented by sub classes
        public abstract void DisplayInfo();

        public string VersionNumber 
        {
            get {return _versionNumber;}
            set { _versionNumber = value;}
        }
        public int BatteryPercentage 
        {
            get {return _batteryPercentage;}
            set { _batteryPercentage = value;}
        }
        public string Carrier 
        {
            get {return _carrier;}
            set { _carrier = value;}
        }
        public string Ringtone
        {
            get {return _ringtone;}
            set { _ringtone = value;}
        }
    }
}