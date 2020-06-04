using System;
using System.Threading.Tasks;


namespace AsyncExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press a key to start async example...");
            Console.ReadLine();
            /* 
             * Start a new cook that cooks pancakes in an asynchronous manner.
             * Due to it being an Async operation, (meaning: there are operations present that might block execution for an unknown variable amount of time)
             * await is needed. This will ensure we will only continue with the next line of code when the complete Async operation has been finished.
             */
            await new Cook().CookPancakesAsync();

            Console.WriteLine("Press a key to start sync example...");
            Console.ReadLine();

            /*
             * This will start a new cook that cooks pancakes in a synchronous manner.
             * This is standard behaviour.
             */
            new Cook().CookPancakesSync();
            Console.WriteLine("Done! Press a key to exit...");
            Console.ReadLine();
        }
    }
}
