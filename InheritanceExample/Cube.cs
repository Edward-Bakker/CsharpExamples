using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Cube : Rectangle
    {
        public int Depth { get; set; }
        public override string GiveName()
        {
            return "Im a Cube and I inherit properties from Rectangle!";
        }
        public string CubeStuff()
        {
            return "Super Cuber, Abba songs define me...";
        }
    }
}
