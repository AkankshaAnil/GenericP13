using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericP13
{
    internal class GenericMaximum2<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        public GenericMaximum2(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >=0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            else
            {
                return default;
            }
        }

        public T MaxMethod()
        {
            T Max = GenericMaximum2<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return Max;
        }
    }
}


