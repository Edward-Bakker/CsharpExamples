using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExample
{
    interface CookHelper
    {
        public Task<bool> DoTask();
    }
}
