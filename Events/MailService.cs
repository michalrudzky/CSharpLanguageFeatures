using System;

namespace Events
{
    public class MailService
    {
        public void OnBookRented(object source, BookEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email... " + args.Book.Title);
        }
    }
}