using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExample.Helpers
{
    class EggHelper
    {
        public async Task<bool> DoTask()
        {
            await Task.Delay(2000);//Simulate that it takes 2 seconds to get eggs.
            return true;
        }
    }
}
