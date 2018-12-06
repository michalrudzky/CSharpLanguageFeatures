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
    }
}
