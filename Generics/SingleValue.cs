using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Constraint: T is a value type
    class SingleValue<T> where T : struct
    {
        private object _value;

        public SingleValue()
        {
        }

        public SingleValue(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T Value
        {
            get
            {
                if (HasValue)
                    return (T) _value;

                return default(T);
            }

            set { _value = value; }
        }
    }
}
