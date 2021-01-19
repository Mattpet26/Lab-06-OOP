using Lab_06_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    public class Dolphin : Mammal, Ridable
    {
        public bool doesTricks { get; set; }
        public bool isFree { get; set; }
        public bool canRide { get; set; }
        public string shouldRide { get; set; }

        public void getHigh()
        {
            Console.WriteLine("Pass the puffer fish");
        }

        public override string makeMilk()
        {
            Console.WriteLine("Make that milk");
            return "Make that milk";
        }

        public void rescueHuman()
        {
            Console.WriteLine("No probs bro, doing my thing.");
        }
    }
}
