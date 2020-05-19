using System;

namespace OOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a default car...");
            Car c1 = new Car();
            Console.WriteLine(c1.GiveCarDetails());
            Console.WriteLine("Making sound after pressing a key...");
            Console.ReadLine();
            Console.WriteLine(c1.HornHonk());
            Console.ReadLine();

            Console.WriteLine("Creating a custom car...");
            Wheel[] w = { new Wheel(Colour.glitter), new Wheel(Colour.rainbow), new Wheel(Colour.green), new Wheel(Colour.blue)}; 
            Car c2 = new Car("Diesel", Sound.doot, w);
            Console.WriteLine(c2.GiveCarDetails());
            Console.WriteLine("Making sound after pressing a key...");
            Console.ReadLine();
            Console.WriteLine(c2.HornHonk());
            Console.ReadLine();

        }
    }
}
