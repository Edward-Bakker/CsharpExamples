using System;
using System.Collections.Generic;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> SL = new List<Shape>(); //Define a list of Shape objects. This includes all classes that inherit from the Shape interface!

            SL.Add(new Rectangle()); //Add a Rectange to the list. This is possible because Rectangle inherits from Shape. Rectangle IS a Shape.
            SL.Add(new Cube()); //Add a Cube to the list. This is possible because Cube extends from Rectangle. Rectangle is a Shape, so Cube is one too.

            Shape s = SL[1];
            /*
             * At this point we have put the created Cube on line 13 in a Shape variable called s (we grabbed it with index 1).
             * Because Cube IS a shape (because it itself is a Rectangle), we can do this. But now we can only treat is AS a Shape.
             * Cube has a method called "CubeStuff()", but we cannot access it from s. This is because s is treated as a Shape (even though it actually is a Cube!).
             * 
             * Try it! Manually type in "s." and intellisense will tell you that it has no "CubeStuff()" method available!
             */

            //s.CubeStuff();

            if (s is Cube) //If s is of type Cube, then we can cast it (dress it up) as a Cube it actually is.
            {
                Cube c = (Cube)s;
                Console.WriteLine(c.CubeStuff());//And now we can access the "CubeStuff()" method!
                Console.WriteLine("Shape s is actually a Cube!");
            }
            else
            {
                Console.WriteLine("Shape s is not a Cube, but another Shape...");
            }
            Console.ReadLine();

            //If we print the name of all shapes in the list, we can get different outcomes due to the different types of shapes we have.
            foreach (Shape shape in SL)
            {
                /* 
                 * If the shape is a Rectangle ->  execute the rectangle "GiveName" method. 
                 * If the shape is a Cube -> execute the cube "GiveName" method.
                 * This "changing" of method outcomes is called Polymorphism.
                 */
                shape.GiveName(); 
            }
        }
    }   
}

