using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    /// <summary>
    /// Grand-parent class. All classes come from here
    /// </summary>
    public abstract class Animal
    {
        public abstract string Carnivore { get; set; }
        public abstract string Herbivore { get; set; }
        public abstract string Omnivore { get; set; }
        public bool Waterboi { get; set; }

        public string eat()
        {
            Console.WriteLine("Nom nom nom...");
            return "Nomnomnom";
        }
        public abstract string sleep();
    }
}
