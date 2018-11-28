using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 5;
            int number3 = 7;
            string text1 = "dog";
            string text2 = "cat";
            string text3 = "dog";

            bool equal1 = Comparator<int>.Equal(number1, number2);
            int max = Comparator<int>.Max(number1, number3);

            Console.WriteLine("{0} = {1} --> {2}", number1, number2, equal1);
            Console.WriteLine("Max({0}, {1}) --> {2}", number1, number3, max);

            SingleValue<int> singleValue = new SingleValue<int>();
            Console.WriteLine(singleValue.HasValue);
            Console.WriteLine($"Object's value: {singleValue.Value} (default)");
            Console.WriteLine($"Setting object's value to {number1}.");
            singleValue.Value = number1;
            Console.WriteLine($"Object's value: {singleValue.Value}");

            int dd = new int();
        }
    }
}
