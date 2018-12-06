using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {4, 16, 21, 7, 13};
            int biggestNumber = numbers.GetMaxValue();
            int smallestNumber = numbers.GetMinValue();

            Console.WriteLine($"Numbers: {numbers.Display()}");
            Console.WriteLine($"Biggest number: {biggestNumber}");
            Console.WriteLine($"Smallest number: {smallestNumber}");
        }
    }
}
