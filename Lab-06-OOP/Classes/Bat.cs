﻿using Lab_06_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    public class Bat : Mammal, FlyBoi, Ridable
    {
        public bool drinksBlood {get;set;}
        public bool solitary { get; set; }
        public bool canFly { get; set; }
        public string name { get; set; }
        public bool canRide { get; set; } = false;
        public string shouldRide { get; set; } 

        public string SCREE()
        {
            Console.WriteLine("SCREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
            return "scree but less";
        }
        public void Scatter()
        {
            Console.WriteLine("Scare Bruce Wayne guys!");
        }

        public override string makeMilk()
        {
            return "batmilk.......yum";
        }
        public override string sleep()
        {
            return "Bats sleep during the day!";
        }
    }
}
