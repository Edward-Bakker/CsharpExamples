using System.Text;

namespace OOExample
{
    class Car
    {
        private Horn Horn;
        private Engine Engine;
        private Wheel[] Wheels = new Wheel[4];
        /// <summary>
        /// Constructor for a default car
        /// </summary>
        public Car()
        {
            Horn = new Horn(Sound.train);
            Engine = new Engine();
            Wheels[0] = new Wheel();
            Wheels[1] = new Wheel();
            Wheels[2] = new Wheel();
            Wheels[3] = new Wheel();   
        }
        /// <summary>
        /// Constructor for a custom car
        /// </summary>
        /// <param name="engineFuel">string containing a fueltype</param>
        /// <param name="s">The sound as defined in the Soud enum</param>
        /// <param name="wheels">An array containing all the wheels</param>
        public Car(string engineFuel, Sound s, Wheel[] wheels)
        {
            Engine = new Engine(engineFuel);
            Horn = new Horn(s);
            Wheels = wheels;
        }
        /// <summary>
        /// Builds a string with the details of a car
        /// </summary>
        /// <returns>A string containing the details of the car</returns>
        public string GiveCarDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===Car Details===");
            sb.AppendLine("The engine runs on " + Engine.FuelType);
            sb.AppendLine("The car has the following wheels:");
            foreach (Wheel w in Wheels)
            {
                sb.AppendLine("A wheel with the colour " + w.WheelColour.ToString());
            }
            sb.Append("=================");
            return sb.ToString();
        }
        /// <summary>
        /// Honks the horn of the car
        /// </summary>
        /// <returns>A string whether it succeeded or not</returns>
        public string HornHonk()
        {
            return Horn.MakeSound();
        }
    }
}
