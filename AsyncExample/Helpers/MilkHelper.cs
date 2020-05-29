using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample.Helpers
{
    class MilkHelper:CookHelper
    {
        public async Task<bool> DoTask()
        {
            await Task.Delay(5000);//Simulate that it takes 5 seconds to get milk.
            return true;
        }

    }
}
