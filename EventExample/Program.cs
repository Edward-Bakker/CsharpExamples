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
            try
            {
                Rectangle r = (Rectangle)sender;
                Console.WriteLine("Value changed: Length {0}", r.Length);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            
        }
    }
}
