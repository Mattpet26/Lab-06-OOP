using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    /// <summary>
    /// child to reptiles, grand-child to animals
    /// must sunbask as well.
    /// </summary>
    public class Lizard : Reptile
    {
        public int TongueLength { get; set; }
        public int numHorns { get; set; }

        public void RunFunny()
        {
            Console.WriteLine("Fleeeeeeeeeeeeeeeeeeee....or fight, that too");
        }
        virtual public void reGrowTail()
        {
            Console.WriteLine("why you do that man.....now I need a new one");
        }

        public override bool SunBask()
        {
            return true;
        }
    }
}
