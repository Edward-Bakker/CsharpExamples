using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncExample
{
    class Cook
    {
        public async void CookPancakes()
        {
            CookHelper H1 = new FlourHelper();
            await H1.DoTask();


        }


    }
}
