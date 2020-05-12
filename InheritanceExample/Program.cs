using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> SL = new List<Shape>(); //Define a list of Shape objects. This includes all classes that inherit from the Shape interface!

            SL.Add(new Rectangle()); //This is possible because Rectangle inherits from Shape. Rectangle IS a Shape.
            SL.Add(new Cube()); //This is possible because Cube extends from Rectangle. Rectangle is a Shape, so Cube is one too.

            Shape s = SL[0];
            if (s is Cube) //If s is of type Cube, then we can cast it (dress it up) as a Cube.
            {
                Cube c = (Cube)s;
                Console.WriteLine("Shape s is actually a Cube!");
            }
            else
            {
                Console.WriteLine("Shape s is not a Cube, but another Shape...");
            }
            Console.ReadLine();
            
        }
    }   
}

