using Lab_06_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    /// <summary>
    /// child to reptiles
    /// MUST sunbask
    /// </summary>
    public class Snake : Reptile, Ridable
    {
        public int Length { get; set; }
        public bool isSnek { get; set; }
        public bool canRide { get; set; } = true;
        public string shouldRide { get; set ; }

        public void Slither()
        {
            Console.WriteLine("Uhm....sssssssss..sss..s");
        }
        public void Chomp()
        {
            Console.WriteLine("MONCH");
        }

        public override bool SunBask()
        {
            return true;
        }
    }
}
