using System;

namespace Lab06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckZoo();
        }
        public static void CheckZoo()
        {
            Classes.Iguana steve = new Classes.Iguana() { ScaleColor = "Red", LaysEgg = false, Poisonous = true };
            Console.WriteLine("Welcome to the zoo! Meet steve the iguana");
            Console.WriteLine($"Steve is dangerous, so be careful. He is a {steve.ScaleColor} Iguana");
            Console.WriteLine("Iguanas can change color, run the changeColor method below");
            steve.ChangeColor();
            if (steve.Poisonous == true)
            {
                Console.WriteLine("Careful, he is poisonous");
            }
            Console.WriteLine("Running the method, beCool");
            steve.beCool();
        }
    }
}
