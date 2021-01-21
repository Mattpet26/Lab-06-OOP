using Lab_06_OOP.Interface;
using Lab06_OOP.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP.Classes
{
    public class Monkey : Mammal, Ridable, FlyBoi
    {
        public bool canClimb { get; set; } = true;
        public bool solvedProblem { get; set; } = true;
        public bool canRide { get; set; } = true;
        public string shouldRide { get ; set; }
        public bool canFly { get; set; } = false;
        public string name { get; set; }

        public override string makeMilk()
        {
            throw new NotImplementedException();
        }
    }
}
