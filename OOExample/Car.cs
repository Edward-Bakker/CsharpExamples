using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExample
{
    class Car
    {
        public Horn Horn { get; private set; }
        public Engine Engine { get; set; }
        public Wheel[] Wheels = new Wheel[4];

        public Car()
        {
            this.Horn = new Horn();
            this.Engine = new Engine("Patatolie and Melk");
            Wheels[0] = new Wheel();
            Wheels[1] = new Wheel();
            Wheels[2] = new Wheel();
            Wheels[3] = new Wheel();   
        }

        public string GiveEngineDetails()
        {
            return "The engine runs on" + Engine.FuelType;
        }

        public void ChangeEngine()
        {
            this.Engine = new Engine("Alcohol and cola");
        }


    }
}
