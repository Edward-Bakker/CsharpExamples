namespace OOExample
{
    class Wheel
    {
        public Colour WheelColour { get; private set; }
        /// <summary>
        /// Constructor fo a custom wheel
        /// </summary>
        /// <param name="wheelColour">The colour as defined in the Colour enum</param>
        public Wheel(Colour wheelColour)
        {
            WheelColour = wheelColour;
        }
        /// <summary>
        /// Constructor for a default wheel with the colour black
        /// </summary>
        public Wheel()
        {
            WheelColour = Colour.black;
        }
    }
}
