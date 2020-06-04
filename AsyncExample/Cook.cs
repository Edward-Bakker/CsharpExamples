using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using AsyncExample.Helpers;

namespace AsyncExample
{
    class Cook
    {
        /// <summary>
        /// Cook pancakes in an asynchronous manner. 
        /// </summary>
        /// <returns>A task containing a bool result</returns>
        public async Task<bool> CookPancakesAsync()
        {
            //We create a stopwatch to "measure" the time it takes to finish this method.
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Starting...");
            sw.Start();

            //Create 3 tasks that execute the various "DoTaskAsync" methods. This is basically multithreading.
            Task<bool> flourTask = new FlourHelper().DoTaskAsync();
            Task<bool> eggTask = new EggHelper().DoTaskAsync();
            Task<bool> milkTask = new MilkHelper().DoTaskAsync();

            //Do some stuff while the 3 tasks are running in the background
            Console.WriteLine("Meanwhile, preparing cooking utilities");
            Task.Delay(1000).Wait();
            Console.WriteLine("Meanwhile, preparing the table");
            Task.Delay(500).Wait();

            /* At this point, those 3 tasks NEED to be done, thus we put "await" before them. This instructs the program to check if the task has finished. 
             * If the task has finished, continue. If not, store this point of the method execution in memory and return when the task has finished.
             * This will be done automagically.
             */
            await flourTask;
            await eggTask;
            await milkTask;

            //Stop the recording of time and present the elapsed time.
            sw.Stop();
            Console.WriteLine("Done! Time elapsed: {0}", sw.Elapsed);
            Console.WriteLine("Let's build them pancakes!");

            //Always return true, a void method is not awaitable. How can determine if it is done otherwise?
            return true;

        }

        /// <summary>
        /// Cook pancakes in an synchronous manner. 
        /// </summary>
        /// <returns>A boolean result</returns>
        public bool CookPancakesSync()
        {
            //The process in this method is similar to the async version. Only difference is the lack of async operations.
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
