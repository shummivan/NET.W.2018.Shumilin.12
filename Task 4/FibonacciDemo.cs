using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    /// <summary>
    /// Simple class that contains method for generate Fibonacci sequence
    /// </summary>
    public class FibonacciDemo
    {
        /// <summary>
        /// Generate Fibonacci sequence
        /// </summary>
        /// <param name="num">Count elements</param>
        /// <returns>Sequence with enumerator</returns>
        public IEnumerable GetFib(int num)
        {
            long sum = 0;
            long first = 0;
            long second = 1;

            if (num < 0)
            {
                throw new ArgumentException();
            }

            while (num-- > 0)
            {
                sum = first + second;
                first = second;
                second = sum;

                yield return sum;
            }
        }
    }
}
