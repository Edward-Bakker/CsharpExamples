using System;

namespace EventArgsExample
{
    public class StudentAddedEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
