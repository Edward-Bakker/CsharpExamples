using System;
using System.Threading.Tasks;


namespace AsyncExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new Cook().CookPancakesAsync();
            Console.ReadLine();
            new Cook().CookPancakesSync();
            Console.ReadLine();
        }
    }
}
