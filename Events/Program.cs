using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book() {Title = "Some book"};
            var bookRental = new BookRental();      // publisher
            var mailService = new MailService();    // subscriber
            var smsService = new SmsService();      // subscriber

            bookRental.BookRented += mailService.OnBookRented;
            bookRental.BookRented += smsService.OnBookRented;

            bookRental.Rent(book);
        }
    }
}
