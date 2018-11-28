using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // General syntax for lambda expressions: args => expression
            // () => expression
            // x => expression
            // (x, y, z) => expression

            Func<int, int> square = number => number * number;
            Func<int, int, int> multiplier = (num1, num2) => num1 * num2;

            Console.WriteLine($"5 squared is {square(5)}");
            Console.WriteLine("8 * 9 = {0}", multiplier(8, 9));

            List<string> fruitNames = new List<string>(new[] { "apple", "banana", "pear", "strawberry", "orange", "plum", "raspberry" });
            var shortFruitNames = fruitNames.FindAll(f => f.Length <= 5);

            Console.WriteLine("All fruit names: ");
            PrintList(fruitNames);
            Console.WriteLine("Short fruit names: ");
            PrintList(shortFruitNames);
        }

        static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine($"\t- {item}");
            }
        }
    }
}
