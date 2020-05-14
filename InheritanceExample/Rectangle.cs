using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public virtual string GiveName()
        {
            return "Im a rectangle!";
        }
        public string GiveSuperAwesomeRectangleName()
        {
            return "Im the rekt rectangle! Be there or be square!";
        }
    }
}
