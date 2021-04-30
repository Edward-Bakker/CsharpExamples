using System;

namespace EventArgsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Changed += School_Changed;

            school.AddStudent(new Student { Name = "Elon Musk", Age = 49 });
            school.AddStudent(new Student { Name = "Henk Krol", Age = 71 });
            school.AddStudent(new Student { Name = "Giga Chad", Age = 24 });
        }

        private static void School_Changed(object sender, EventArgs e)
        {
            try
            {
                School s = (School)sender;
                StudentAddedEventArgs args = (StudentAddedEventArgs)e;
                Console.WriteLine("Student has been added to school, with name: {0} and age: {1}", args.Name, args.Age);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
