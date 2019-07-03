using System;
using System.Collections.Generic;

namespace phone
{

    public abstract class Phone 
    {
        protected string _versionNumber;
        protected int _batteryPercentage;
        protected string _carrier;
        protected string _ringTone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
    }
        // abstract method. This method will be implemented by the subclasses
        public abstract void DisplayInfo();
        // public getters and setters removed for brevity. Please implement them yourself
        public string VersionNumber {get;set;}
        public string BatteryPercentage {get;set;}
        public string Carrier {get;set;}
        public string Ringtone {get;set;}
    }
}