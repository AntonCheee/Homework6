using NUnit.Framework;
using static ClassLibrary.VariablesHelper;
using System;

namespace UnitTests
{
    public class VariablesHelperTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(-5, 0, -5)]
        public void CalculateEquation_WhenNumber1NotEquelNumber2_ShouldCalculateEquation(double a, double b, double expectedResult)
        {
            double actualResult = CalculateEquation(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEquation_WhenNumber1EquelNumber2_ShouldThrowException()
        {
            try
            {
                double actualResult = CalculateEquation(3.5, 3.5);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Numbers are same", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(3.5, 0.5)]
        [TestCase(3.5, 3.5)]
        [TestCase(3.5, null)]
        [TestCase(0, 0)]
        public void SwapNumber_ShoudSwapNumbers(double number1, double number2)
        {
            double number1Temp = number1;
            double number2Temp = number2;

            Swap(ref number1, ref number2);

            Assert.AreEqual(number1Temp, number2);
            Assert.AreEqual(number2Temp, number1);
        }

        [TestCase(5, 2, 2.5)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(10, -2, -5)]
        [TestCase(0, 2, 0)]
        public void Divide_WhenDivisorIsNotZero_ShouldDivide(int dividend, int divisor, double expectedResult)
        {
            double actualResult = Divide(dividend, divisor);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Divide_WhenDivisorIsZero_ShouldThrowException()
        {
            try
            {
                double result = Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Divisor is equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(5, 2, 1)]
        [TestCase(5, 5, 0)]
        [TestCase(0, 2, 0)]
        [TestCase(15, 10, 5)]
        [TestCase(5, 10, 5)]
        [TestCase(5, 1, 0)]
        public void GetRemainderOfDivision_WhenDivisorIsNotZero_ShouldCalculateRemainderOfDivision(int dividend, int divisor, double expectedResult)
        {
            double actualResult = GetRemainderOfDivision(dividend, divisor);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetRemainderOfDivision_WhenDivisorIsZero_ShouldThrowException()
        {
            try
            {
                double result = GetRemainderOfDivision(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Divisor is equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [Test]
        public void CalculationOfLinearEquationOfStandardForm_WhenANotEqualZero_ShouldCalculateLinearEquation()
        {
            double result = CalculationOfLinearEquationOfStandardForm(4, 5, 10);

            Assert.AreEqual(1.25, result);
        }

        [Test]
        public void CalculationOfLinearEquationOfStandardForm_WhenAEqualZero_ShouldThrowException()
        {
            try
            {
                double result = CalculationOfLinearEquationOfStandardForm(0, 5, 10);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Divisor is equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [Test]
        public void CalculateEquationOfLineByTwoPoints_WhenX1NotEqualX2_ShouldCalculateEquationOfLine()
        {
            string result = CalculateEquationOfLineByTwoPoints(2, 6, 1, 4);

            Assert.AreEqual("Y= 2*X + 2", result);
        }

        [Test]
        public void CalculateEquationOfLineByTwoPoints_WhenAEqualZero_ShouldThrowException()
        {
            try
            {
                string result = CalculateEquationOfLineByTwoPoints(2, 6, 2, 10);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("x1 equals x2", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }
    }
}