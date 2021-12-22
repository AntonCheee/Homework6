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

        [Test]
        public void SwapNumber_ShoudSwapNumbers()
        {
            double number1 = 3.5;
            double number2 = 0.5;

            Swap(ref number1, ref number2);

            Assert.AreEqual(0.5, number1);
            Assert.AreEqual(3.5, number2);
        }

        [Test]
        public void Divide_WhenDivisorIsNotZero_ShouldDivide()
        {
            double result = Divide(5, 2);

            Assert.AreEqual(2.5, result);
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

        [Test]
        public void GetRemainderOfDivision_WhenDivisorIsNotZero_ShouldCalculateRemainderOfDivision()
        {
            double result = GetRemainderOfDivision(5, 2);

            Assert.AreEqual(1, result);
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