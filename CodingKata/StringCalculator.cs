using System;
using System.Linq;

namespace CodingKata
{
    public class StringCalculator
    {
        /// <summary>
        /// Follow TDD approach and add the numbers in the input string and return its sum.
        /// Input can have one or more numbers with a comma separated delimiter.
        /// </summary>
        /// <param name="numbers">Input numbers separated by comma delimiter</param>
        /// <returns>Sum of input numbers</returns>
        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            return numbers.Split(',')
                .Select(x => Int32.Parse((string) x))
                .Sum();
        }
    }
}