using System;

namespace ValueReferenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //We create a class, which is a reference type.
            Rectangle r1, r2;
            r1 = new Rectangle { Length = 10.0, Width = 20.0 };
            r2 = r1; //Here we reference r1 to r2, meaning that both r1 and r2 point to the same object!
            r2.Length = 30.0; //Thus changing r2, will result in the change of r1.
            Console.WriteLine("r1 class value = {0}",r1.Length);

            //We create a struct, which is a value type.
            RectangleStruct rs1, rs2;
            rs1 = new RectangleStruct { Length = 10.0, Width = 20.0 };
            rs2 = rs1;//Here we copy the data from rs1 to rs2. This because a struct is a value type. rs1 and rs2 are different objects in memory!
            rs2.Length = 30.0; //Thus changing rs2 will not result in the change of rs1.
            Console.WriteLine("rs1 struct value = {0}", rs1.Length);
            Console.ReadLine();
        }
    }

    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }
    public struct RectangleStruct
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }
}
