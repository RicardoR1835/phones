using System;
using System.Collections.Generic;


namespace phone
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return $"... {_ringTone}...";
        }
        public string Unlock() 
        {
            return "Samsung is unlocked with your eyes";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine($"***********************************************");
            Console.WriteLine($"Galaxy {_versionNumber}");
            Console.WriteLine($"Battery Percentage: {_batteryPercentage}");
            Console.WriteLine($"Carrier: {_carrier}");
            Console.WriteLine($"Ring Tone: {_ringTone}");
            Console.WriteLine($"***********************************************");
        }
    }
 
}