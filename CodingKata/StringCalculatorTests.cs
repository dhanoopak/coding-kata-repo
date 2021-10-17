using System.Runtime.InteropServices.WindowsRuntime;
using Xunit;

namespace CodingKata
{
    /// <summary>
    /// Below test is for practicing Test Driven Development using a simple string calculator program.
    /// Coding Kata is followed for the implementation.
    /// </summary>
    public class StringCalculatorTests
    {
        [Fact]
        public void AddEmptyNumberReturnZero()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int returnValue = stringCalculator.Add("");

            Assert.Equal(0, returnValue);
        }

        [Fact]
        public void AddNumberReturnSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int returnValue = stringCalculator.Add("1");

            Assert.Equal(1, returnValue);
        }

        [Fact]
        public void AddNumbersWithCommaSeperatoreReturnSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int returnValue1 = stringCalculator.Add("1,2");

            Assert.Equal(3, returnValue1);
        }


        [Fact]
        public void AllowUnknownNumbersWithCommaSeperatoreReturnSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int returnValue1 = stringCalculator.Add("1,2,3,4,5,6,7,8,9");

            Assert.Equal(45, returnValue1);
        }
    }
}
