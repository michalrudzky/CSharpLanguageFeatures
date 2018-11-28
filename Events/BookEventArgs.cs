using System;

namespace Events
{
    public class BookEventArgs : EventArgs
    {
        public Book Book { get; set; }
    }
}