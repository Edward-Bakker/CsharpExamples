using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExample
{
    class Car
    {
        private Horn Horn;
        private Engine Engine;
        public Wheel[] Wheels = new Wheel[4];

        public Car()
        {
            Horn = new Horn(Sound.train);
            Engine = new Engine();
            Wheels[0] = new Wheel();
            Wheels[1] = new Wheel();
            Wheels[2] = new Wheel();
            Wheels[3] = new Wheel();   
        }

        public Car(string engineFuel, Sound s, Wheel[] wheels)
        {
            Engine = new Engine(engineFuel);
            Horn = new Horn(s);
            Wheels = wheels;
        }

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

        public string HornHonk()
        {
            return Horn.MakeSound();
        }


    }
}
