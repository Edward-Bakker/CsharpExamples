using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    class Rectangle
    {
        public event EventHandler Changed; //Define an event called "Changed" other classes could subscribe to.

        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                RectangleChangedEventArgs args = new RectangleChangedEventArgs { Length = length, Width = value, Date = DateTime.UtcNow };
                Changed(this, args);//Everytime the Description property changes the description field, the "Changed" event will fire thus informing subscribers.
            }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                RectangleChangedEventArgs args = new RectangleChangedEventArgs { Length = value, Width = width, Date = DateTime.UtcNow };
                Changed(this, args);//Everytime the Length property changes the length field, the "Changed" event will fire thus informing subscribers.
            }
        }
    }
}
