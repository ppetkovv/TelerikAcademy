using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.cs
{
    public static class IEnumExtensions
    {
        public static decimal Sum<T>(this IEnumerable<T> collection) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            decimal sum = 0;
            foreach (T number in collection)
            {
                sum += number.ToDecimal(CultureInfo.CurrentCulture);
            }
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            decimal product = 1;
            foreach (T number in collection)
            {
                product *= number.ToDecimal(CultureInfo.CurrentCulture);
            }
            return product;
        }

        public static decimal Min<T>(this IEnumerable<T> collection) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            decimal min = Decimal.MaxValue;
            decimal currentNumber = 0;
            foreach (T number in collection)
            {
                currentNumber = number.ToDecimal(CultureInfo.CurrentCulture);
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }
            return min;
        }

        public static decimal Max<T>(this IEnumerable<T> collection) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            decimal max = Decimal.MinValue;
            decimal currentNumber = 0;
            foreach (T number in collection)
            {
                currentNumber = number.ToDecimal(CultureInfo.CurrentCulture);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            decimal average = 0;
            byte counter = 0;
            foreach (T number in collection)
            {
                average += number.ToDecimal(CultureInfo.CurrentCulture);
                counter++;
            }
            return average / counter;
        }
    }
}