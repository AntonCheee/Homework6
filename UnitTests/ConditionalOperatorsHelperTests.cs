using System;
using NUnit.Framework;
using static ClassLibrary.ConditionalOperatorsHelper;

namespace UnitTests
{
    class ConditionalOperatorsHelperTests
    {
        [TestCase(6.5, 5, 11.5)]
        [TestCase(5, 6.5, -1.5)]
        [TestCase(5.5, 5.5, 30.25)]
        public static void MathOperationAfterComparingNumbers_ShouldCalculateResult(double a, double b, double expectedResult)
        {
            double actualResult = MathOperationAfterComparingNumbers(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(-1, 1, 4)]
        public static void FindingQuadrantOfPoint_WhenPointNotOnCoordinateAxis_ShouldDefineQuadrant(double x, double y, int expectedResult)
        {
            double actualResult = FindingQuadrantOfPoint(x, y);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 0)]
        [TestCase(0, -1)]
        [TestCase(0, 0)]
        public static void FindingQuadrantOfPoint_WhenPointOnCoordinateAxis_ShouldDefineQuadrant(double x, double y)
        {
            try
            {
                FindingQuadrantOfPoint(x, y);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The point is on the coordinate axis", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCaseSource(nameof(Tuple))]
        public static void OrderThreeNumber_ShouldSortSequence(int x, int y, int c, (int, int, int) expectedResult)
        {
            (int, int, int) actualResult = OrderThreeNumber(x, y, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] Tuple = new[]
        {
            new object[] { -1, 5, 0, (-1, 0, 5) },
            new object[] { 6, 5, 4, (4, 5, 6) },
            new object[] { -5, -7, -1, (-7, -5, -1) },
            new object[] { 1, 1, 1, (1, 1, 1) }
        };

        [TestCaseSource(nameof(Coefficient1))]
        public static void SolvingQuadraticEquations_WhenANotEqualZero_ShouldCalculateQuadraticEquations(double a, double b, double c, (int, int) expectedResult)
        {
            (double, double) actualResult = SolvingQuadraticEquations(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] Coefficient1 = new[]
        {
            new object[] { 2, 4, 0, (0, -2) },
            new object[] { 6, 0, -6, (1, -1) },
            new object[] { 1, 0, 0, (0, 0) }
        };

        [TestCaseSource(nameof(Coefficient2))]
        public static void SolvingQuadraticEquations_WhenDiscriminantLessZero_ShouldThrowException(double a, double b, double c)
        {
            try
            {
                SolvingQuadraticEquations(a, b, c);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("There is no solution of quadratic equation", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] Coefficient2 = new[]
        {
            new object[] { 1, 0, 1 },
            new object[] { 1, -2, 3 }
        };

        [TestCaseSource(nameof(Coefficient3))]
        public static void SolvingQuadraticEquations_WhenAEqualZero_ShouldThrowException(double a, double b, double c)
        {
            try
            {
                SolvingQuadraticEquations(a, b, c);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("There is no solution of quadratic equation for A = 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] Coefficient3 = new[]
        {
            new object[] { 0, 1, 1 }
        };

        [TestCase(10, "ten")]
        [TestCase(99, "ninety-nine")]
        [TestCase(52, "fifty-two")]
        public static void ConvertNumberIntoWords_ShouldBeConvertInString(int number, string expectedResult)
        {
            string actualResult = ConvertNumberIntoWords(number);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}