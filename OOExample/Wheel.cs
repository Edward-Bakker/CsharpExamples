using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExample
{
    class Wheel
    {
        public Colour WheelColour { get; private set; }

        public Wheel(Colour wheelColour)
        {
            WheelColour = wheelColour;
        }
        public Wheel()
        {
            WheelColour = Colour.black;
        }
    }
}
