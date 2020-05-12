using System;
using System.Collections.Generic;

namespace DelegateExample
{
    class Program
    {
        public delegate bool FilterDelegate(Student s); //The delegate, see it as a person that knows how to work with 1 student object but in a very broad manner
        static List<Student> StudentList = new List<Student>();
        static void Main(string[] args)
        {
            StudentList.Add(new Student("Zanger Rinus", 10, "Purple"));
            StudentList.Add(new Student("Arnold Schwarzenegger", 80, "Grey"));
            StudentList.Add(new Student("Rick Astley", 14, "Black"));

            ShowStudents(StudentList, AgeFilter);
            Console.ReadLine();
            ShowStudents(StudentList, NameFilter);
            Console.ReadLine();
            ShowStudents(StudentList, AgeNameFilter); //Will return nothing!
            Console.ReadLine();
            ShowStudents(StudentList, HairColourFilter);
            Console.ReadLine();
        }
        static void ShowStudents(List<Student> students, FilterDelegate filter)
        {
            foreach (Student s in students)
            {
                if (filter(s))
                {
                    Console.WriteLine(s.Name);
                }
            }
        }
        static bool AgeFilter(Student s)
        {
            return s.Age > 17;
        }
        static bool NameFilter(Student s)
        {
            return s.Name.Contains("u");
        }
        static bool AgeNameFilter(Student s)
        {
            return s.Age > 17 && s.Name.Contains("u");
        }
        static bool HairColourFilter(Student s)
        {
            return s.HairColour == "Black";
        }


    }
}
