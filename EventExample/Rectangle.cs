using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    class Rectangle
    {
        public event EventHandler Changed; //Define an event called "Changed" other classes could subscribe to.

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                Changed(this, EventArgs.Empty);//Everytime the Length property changes the length field, the "Changed" event will fire thus informing subscribers.
            }
        }
    }
}
