using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AsyncExample.Helpers;

namespace AsyncExample
{
    class Cook
    {
        public async Task<bool> CookPancakesAsync()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Starting...");
            sw.Start();


            Task<bool> flourTask = new FlourHelper().DoTaskAsync();
            Task<bool> eggTask = new EggHelper().DoTaskAsync();
            Task<bool> milkTask = new MilkHelper().DoTaskAsync();

            Console.WriteLine("Meanwhile, preparing cooking utilities");
            Task.Delay(1000).Wait();
            Console.WriteLine("Meanwhile, preparing the table");
            Task.Delay(500).Wait();

            await flourTask;
            await eggTask;
            await milkTask;

            sw.Stop();
            Console.WriteLine("Done! Time elapsed: {0}", sw.Elapsed);
            Console.WriteLine("Let's build them pancakes!");
            return true;

        }

        public bool CookPancakesSync()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Starting...");
            sw.Start();

            new FlourHelper().DoTaskSync();
            new EggHelper().DoTaskSync();
            new MilkHelper().DoTaskSync();

            Console.WriteLine("Preparing cooking utilities");
            Thread.Sleep(1000);
            Console.WriteLine("Preparing the table");
            Thread.Sleep(500);

            sw.Stop();
            Console.WriteLine("Done! Time elapsed: {0}", sw.Elapsed);
            Console.WriteLine("Let's build them pancakes!");
            return true;
        }
    }
}
