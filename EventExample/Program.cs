using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Changed += new EventHandler(R_Changed); //Here we subscribe to the "Changed" event in the rectangle. Whenever the event is "fired", the R_Changed method will execute.
            //r.Changed += R_Changed;

            r.Length = 10; //We change the Length, thus the event should fire. 
            r.Length = 20;
            r.Length = 30;
        }

        private static void R_Changed(object sender, EventArgs e)
        {
            try //We are "trying" the code on line 22 and 23.
            {
                Rectangle r = (Rectangle)sender; //Because there is a possibility that this "cast" is not possible.
                Console.WriteLine("Value changed: Length {0}", r.Length);
            }
            catch(Exception ex) //If the cast fails, we catch the exception thus the application does not crash.
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            
        }
    }
}
