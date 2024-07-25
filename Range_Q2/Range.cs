using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_1.Range_Q2
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T minimum, T maximum)
        {
            if (minimum == null || maximum == null)
                throw new ArgumentNullException(nameof(minimum));
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }

            Min = minimum;
            Max = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public T Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }
    }
}
