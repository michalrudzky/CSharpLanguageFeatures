using System;

namespace Events
{
    public class SmsService
    {
        public void OnBookRented(object source, BookEventArgs args)
        {
            Console.WriteLine("SmsService: Sending an SMS... " + args.Book.Title);
        }
    }
}