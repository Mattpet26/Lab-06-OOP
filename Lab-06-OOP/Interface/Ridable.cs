using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP.Interface
{
    interface Ridable
    {
        public bool canRide { get; set; }
        public string shouldRide { get; set; }

        public string mount()
        {
            return "All aboard";
        }
        public string HopOff()
        {
            return "Everyone get off!";
        }
    }
}
