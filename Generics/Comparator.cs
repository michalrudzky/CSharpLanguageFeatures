using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Constraint: T implements the IComparable interface
    public class Comparator<T> where T : IComparable
    {
        public static bool Equal(T a, T b)
        {
            return a.Equals(b);
        }

        public static T Max(T a, T b)
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }
    }
}
