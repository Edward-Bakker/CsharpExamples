using System;

namespace LessonAssignment
{
    public class StudentAddedEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
