using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample.Helpers
{
    class EggHelper : CookHelper
    {
        public async Task<bool> DoTaskAsync()
        {
            Console.WriteLine("Grabbing Eggs");
            await Task.Delay(2000);//Simulate that it takes 2 seconds to get eggs.
            Console.WriteLine("Eggs grabbed");
            return true;
        }

        public bool DoTaskSync()
        {
            Console.WriteLine("Grabbing Eggs");
            Thread.Sleep(2000);//Simulate that it takes 2 seconds to get eggs.
            Console.WriteLine("Eggs grabbed");
            return true;
        }
    }
}
