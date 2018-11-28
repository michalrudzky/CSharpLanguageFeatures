using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class BookRental
    {
        // 1. Define a delegate
        // 2. Define an event based on the delegate
        // 3. Raise the event

        //public delegate void BookRentedEventHandler(object source, BookEventArgs args);
        //public event BookRentedEventHandler BookRented;

        public event EventHandler<BookEventArgs> BookRented; 

        public void Rent(Book book)
        {
            Console.WriteLine("Book rented...");
            Thread.Sleep(3000);

            OnBookRented(book);
        }

        // Event publisher method
        protected virtual void OnBookRented(Book book)
        {
            if (BookRented != null)
            {
                BookRented(this, new BookEventArgs() {Book = book});
            }
        }
    }
}
