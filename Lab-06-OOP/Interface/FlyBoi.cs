using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_OOP.Interface
{
    interface FlyBoi
    {
        public bool canFly { get; set; }
        public string name { get; set; }

        public string TakeOff()
        {
            return "Flap...flap......fly";
        }
        public string Land()
        {
            return "You have arrived at your destination";
        }
    }
}
