using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.Classes
{
    /// <summary>
    /// Child to lizard
    /// grand-child to reptiles
    /// great-grand-children to animals
    /// </summary>
    public class Iguana : Lizard
    {
        public bool fullyGrown { get; set; }
        public bool likesFrank { get; set; } = false;

        public void ChangeColor() 
        {
            Console.WriteLine("Pick a color, any color.");
        }
        public string beCool()
        {
            Console.WriteLine("I'm just better than you");
            likesFrank = true;
            return "I'm just better than you";
        }
    }
}
