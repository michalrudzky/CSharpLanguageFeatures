using System.Collections.Generic;

namespace Linq
{
    public class BookCollection
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "1984", Price = 4.99m},
                new Book() {Title = "Brave New World", Price = 3.89m},
                new Book() {Title = "The Little Prince", Price = 2.99m},
                new Book() {Title = "The Hobbit", Price = 7.99m},
                new Book() {Title = "The Great Gatsby", Price = 12.99m}
            };
        }
    }
}
