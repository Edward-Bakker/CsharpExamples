using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample.Helpers
{
    class MilkHelper:CookHelper
    {
        public async Task<bool> DoTaskAsync()
        {
            Console.WriteLine("Grabbing Milk");
            await Task.Delay(5000);//Simulate that it takes 5 seconds to get milk.
            Console.WriteLine("Milk grabbed");
            return true;
        }

        public bool DoTaskSync()
        {
            Console.WriteLine("Grabbing Milk");
            Thread.Sleep(5000);//Simulate that it takes 5 seconds to get milk.
            Console.WriteLine("Milk grabbed");
            return true;
        }
    }
}
