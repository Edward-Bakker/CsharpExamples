using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample
{
    class FlourHelper : CookHelper
    {
        public async Task<bool> DoTask()
        {
            await Task.Delay(10000);//Simulate that it takes 10 seconds to get flour.
            return true;
        }
    }
}
