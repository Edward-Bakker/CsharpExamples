using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.GiveEngineDetails());
            Console.ReadLine();
            c.ChangeEngine();

            Console.WriteLine(c.GiveEngineDetails());
            Console.ReadLine();
        }
    }
}
