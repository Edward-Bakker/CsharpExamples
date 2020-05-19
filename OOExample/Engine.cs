using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOExample
{
    class Engine
    {
        public string FuelType { get; private set; }
        /// <summary>
        /// Constructor for a custom engine
        /// </summary>
        /// <param name="fuelType">A string containing the fueltype</param>
        public Engine(string fuelType)
        {
            FuelType = fuelType;
        }
        /// <summary>
        /// Constructor for a default engine that runs on petrol
        /// </summary>
        public Engine()
        {
            FuelType = "Petrol";
        }
    }
}
