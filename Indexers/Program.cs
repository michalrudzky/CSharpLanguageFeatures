using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = -1;
            do
            {
                Console.WriteLine("Enter the size of the array: ");
                int.TryParse(Console.ReadLine(), out size);
            } while (size <= 0);

            var nums = new CustomArray<int>(size);
            Random generator = new Random();
            
            // Fill the array with random numbers
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = generator.Next(1, 100);
            }

            Console.WriteLine("\nArray contents:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
