using System;
using System.Collections.Generic;

namespace EventArgsExample
{
    class School
    {
        private List<Student> StudentList = new List<Student>();
        public event EventHandler Changed;

        public void AddStudent(Student s)
        {
            StudentList.Add(s);
            StudentAddedEventArgs args = new StudentAddedEventArgs
            {
                Name = s.Name,
                Age = s.Age
            };
            Changed(this, args);
        }
    }
}
