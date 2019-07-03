using System;
using System.Collections.Generic;


namespace phone
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return $"... {_ringTone}...";
        }
        public string Unlock() 
        {
            return "Nokia is unlocked with your face";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("================================================");
            Console.WriteLine($"Galaxy {_versionNumber}");
            Console.WriteLine($"Battery Percentage: {_batteryPercentage}");
            Console.WriteLine($"Carrier: {_carrier}");
            Console.WriteLine($"Ring Tone: {_ringTone}");
            Console.WriteLine("================================================");
        }
    }
 
}