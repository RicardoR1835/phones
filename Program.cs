using System;
using System.Collections.Generic;


namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "Sprint", "hammmboooonnnniiiinnnngggg");
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            s8.DisplayInfo();
            Nokia Ello = new Nokia("110011", 45, "T-Mobile", "beep boop beep");
            Console.WriteLine(Ello.Ring());
            Console.WriteLine(Ello.Unlock());
            Ello.DisplayInfo();
        }
    }
}
