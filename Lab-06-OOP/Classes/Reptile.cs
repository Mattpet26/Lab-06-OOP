using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    /// <summary>
    /// Animal class splits to reptiles. 
    /// We HAVE to utilize abstract classes taken from animal (herb,carn,omn)
    /// We set our own new abstract + virtual classes
    /// </summary>
    abstract public class Reptile : Animal
    {
        public bool LaysEgg { get; set; } = true;
        virtual public bool Poisonous { get; set; } = false;
        public int Age { get; set; }
        public string ScaleColor { get; set; }
        public override string Carnivore { get; set; }
        public override string Herbivore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Omnivore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        abstract public bool SunBask();
        virtual public void Hide()
        {
            Console.WriteLine("Thats a good spot yo...Move over!");
        }

        public override string sleep()
        {
            return "Zzzzzzzzzzzzz";
        }
    }
}
