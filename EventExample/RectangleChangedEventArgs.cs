using System;

namespace EventExample
{
    class RectangleChangedEventArgs : EventArgs
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public DateTime Date { get; set; }
    }
}
