using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    public abstract class Mammal : Animal
    {
        public bool fourLegs { get; set; }
        virtual public bool domesticated { get; set; }
        public string likable { get; set; }
        public override string Carnivore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Herbivore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Omnivore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        abstract public string makeMilk();
        public void CleanFur()
        {
            Console.WriteLine("Clean time!");
        }

        public override string sleep()
        {
            return "Zzzz";
        }
    }
}
