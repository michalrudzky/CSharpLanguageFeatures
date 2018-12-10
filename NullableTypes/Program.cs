using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable type declaration
            DateTime? date = null;
            Nullable<bool> truth = true;
            int?[] nullableArray = new int?[7];

            // Null coalescing operator
            DateTime newDate = date ?? DateTime.Today;

            Console.WriteLine($"Default DateTime value -> {date.GetValueOrDefault()}");
            Console.WriteLine($"date.HasValue -> {date.HasValue}");
            Console.WriteLine($"Today's date -> {newDate}");
        }
    }
}
