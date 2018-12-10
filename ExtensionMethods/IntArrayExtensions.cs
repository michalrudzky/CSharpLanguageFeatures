using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntArrayExtensions
    {
        public static int GetMaxValue(this int[] array)
        {
            int max = Int32.MinValue;

            foreach (int number in array)
            {
                max = number > max ? number : max;
            }

            return max;
        }

        public static int GetMinValue(this int[] array)
        {
            int min = Int32.MaxValue;

            foreach (int number in array)
            {
                if (number < min)
                    min = number;
            }

            return min;
        }

        public static string Display(this int[] array)
        {
            string text = "";

            for (int i = 0; i < array.Length; i++)
            {
                text += $"{array[i]}";

                if (i == array.Length - 1)
                    break;

                text += ", ";
            }

            return text;
        }

        public static void SortDescending(this int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public static int[] SortMeandering(this int[] array)
        {
            int[] inputArray = (int[]) array.Clone();
            int[] outputArray = new int[array.Length];

            Array.Sort(inputArray);
            Array.Reverse(inputArray);

            for (int i = 0, j = 0; j < array.Length; i++, j += 2)
            {
                if (j == array.Length - 1 && j % 2 == 0)
                {
                    outputArray[j] = inputArray[j / 2];
                    break;
                }

                outputArray[j] = inputArray[i];
                outputArray[j + 1] = inputArray[array.Length - (i + 1)];
            }

            return outputArray;
        }
    }
}
