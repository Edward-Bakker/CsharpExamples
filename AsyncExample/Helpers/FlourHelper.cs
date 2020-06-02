using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample
{
    class FlourHelper : CookHelper
    {
        public async Task<bool> DoTaskAsync()
        {
            Console.WriteLine("Grabbing Flour");
            await Task.Delay(10000);//Simulate that it takes 10 seconds to get flour.
            Console.WriteLine("Flour grabbed");
            return true;
        }

        public bool DoTaskSync()
        {
            Console.WriteLine("Grabbing Flour");
            Thread.Sleep(10000);//Simulate that it takes 10 seconds to get flour.
            Console.WriteLine("Flour grabbed");
            return true;
        }
    }
}
