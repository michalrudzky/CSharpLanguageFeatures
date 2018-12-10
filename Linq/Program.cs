using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = BookCollection.GetBooks();


            // LINQ query operators
            var veryCheapBooks =
                from b in books
                where b.Price < 5m
                orderby b.Title
                select b;

            // LINQ extension methods
            var cheapBooks = books
                .Where(b => b.Price < 10m)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            var singleBook = books.SingleOrDefault(b => b.Title == "Brave New World");
            var firstBook = books.FirstOrDefault();
            var lastBook = books.LastOrDefault();
            var middleBook = books.Skip(2).Take(1).First();

            var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrice = books.Sum(b => b.Price);


            Console.WriteLine("All books:");
            DisplayCollection(books);
            Console.WriteLine("\nCheap books (titles):");
            DisplayCollection(cheapBooks);

            Console.WriteLine($"\nFirst book: {firstBook}");
            Console.WriteLine($"Last book: {lastBook}");
            Console.WriteLine($"Middle book: {middleBook}");

            Console.WriteLine($"\nAmount of books: {count}");
            Console.WriteLine($"Highest price: {maxPrice}");
            Console.WriteLine($"Lowest price: {minPrice}");
            Console.WriteLine($"Total price: {totalPrice}");
        }

        // Extension methods
        /*
         * Single
         * SingleOrDefault
         * First
         * FirstOrDefault
         * Last
         * LastOrDefault
         * Take(num)
         * Skip(num)
         * Count()
         * Max()
         * Min()
         * Sum()
         */

        static void DisplayCollection<T>(IEnumerable<T> collection) where T : class 
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"- {item.ToString()}");
            }
        }
    }
}
