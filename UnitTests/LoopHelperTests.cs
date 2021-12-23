using System;
using NUnit.Framework;
using static ClassLibrary.LoopsHelper;

namespace UnitTests
{
    class LoopHelperTests
    {
        [TestCase(0, 5, 0)]
        [TestCase(1, 5, 1)]
        [TestCase(5, 1, 5)]
        [TestCase(5, 0, 1)]
        [TestCase(5, 3, 125)]
        public static void Exponentiate_ShouldBeCalculatedExponentiate(double number, int degree, int expectedResult)
        {
            double actualResult = Exponentiate(number, degree);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(typeof(FindNumbersDivisibleByEnteredNumberTestScenario))]
        public static void FindNumbersDivisibleByEnteredNumber_ShouldCalculateNumbers(int number, int[] expectedResult)
        {
            int[] actualResult = FindNumbersDivisibleByEnteredNumber(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindNumbersDivisibleByEnteredNumber_WhenEnteredNumberEqualZero_ShouldThrowException()
        {
            try
            {
                FindNumbersDivisibleByEnteredNumber(0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Number can not be equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [Test]
        public static void FindNumbersDivisibleByEnteredNumber_WhenEnteredNumberLessZero_ShouldThrowException()
        {
            try
            {
                FindNumbersDivisibleByEnteredNumber(0);

            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Number can not be equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(9, 2)]
        [TestCase(9.01, 3)]
        [TestCase(1000, 31)]
        public static void PowerCount_ShouldCalculateNumbers(double number, int expectedResult)
        {
            int actualResult = PowerCount(number);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase(-2, 1)]
        [TestCase(8, 4)]
        [TestCase(67, 1)]
        [TestCase(1000, 500)]
        public static void MaxDivider_ShouldCalculateNumbers(int number, int expectedResult)
        {
            int actualResult = MaxDivider(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public static void MaxDivider_WhenNumberEqualMinusOneOrZeroOrOne_ShouldThrowException(int number)
        {
            try
            {
                MaxDivider(number);

            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual($"There are no solution for number = {number}", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }


        [TestCase(0, 6, 0)]
        [TestCase(6, 6, 0)]
        [TestCase(14, 14, 14)]
        [TestCase(0, 100, 735)]
        public static void SumFromAToB_WhenNumbersArePositive_ShouldCalculateResult(int a, int b, int expectedResult)
        {
            int actualResult = SumFromAToB(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-15, 15)]
        [TestCase(-21, -5)]
        [TestCase(0, -21)]
        public static void SumFromAToB_WhenNumbersAreNegative_ShouldThrowException(int a, int b)
        {
            try
            {
                SumFromAToB(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers should be more or equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(7, 13)]
        [TestCase(30, 832040)]
        public static void FibonacciSequence_WhenNumbersArePositive_ShouldCalculateResult(int a, int expectedResult)
        {
            int actualResult = FibonacciSequence(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public static void FibonacciSequence_WhenNumbersLessOrEqualZero_ShouldThrowException(int a)
        {
            try
            {
                FibonacciSequence(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers should be more than 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(0, 0, 1)]
        [TestCase(0, 10, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 7, 1)]
        [TestCase(12, 16, 4)]
        [TestCase(28272, 2128, 304)]

        public static void EuclideanAlgorithm_WhenNumbersArePositive_ShouldCalculateResult(int a, int b, int expectedResult)
        {
            int actualResult = EuclideanAlgorithm(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-4, -8)]
        [TestCase(-4, 8)]
        [TestCase(4, -8)]
        public static void EuclideanAlgorithm_WhenNumbersAreNegotive_ShouldThrowException(int a, int b)
        {
            try
            {
                EuclideanAlgorithm(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers should be more or equal 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }


        [TestCase(1, 1)]
        [TestCase(7, 1.9129d)]
        [TestCase(1000, 10)]
        public static void HalfDivisionMethod_ShouldCalculateResult(double a, double expectedResult)
        {
            double actualResult = HalfDivisionMethod(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-4.56)]
        public static void HalfDivisionMethod_WhenNumberAreLessOrEqualZero_ShouldThrowException(double a)
        {
            try
            {
                HalfDivisionMethod(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers should be more than 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(-132, 2)]
        [TestCase(-1, 1)]
        [TestCase(532, 2)]
        [TestCase(460, 0)]
        [TestCase(537, 3)]
        public static void CountOddNumber_WhenNumberNotIsEqualZero_ShouldCalculateResult(int a, int expectedResult)
        {
            double actualResult = CountOddNumber(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void CountOddNumber_WhenNumberIsEqualZero_ShouldThrowException()
        {
            try
            {
                CountOddNumber(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers can not be 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(-132, -231)]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(5328, 8235)]
        [TestCase(11111, 11111)]
        public static void Reverseo_ShouldCalculateResult(int a, int expectedResult)
        {
            double actualResult = Reverse(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(nameof(SumEvenMoreSumOddSource))]
        public static void SumEvenMoreSumOdd_WhenNumberMoreZero_ShouldCalculateResult(int a, int[] expectedResult)
        {
            int[] actualResult = SumEvenMoreSumOdd(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] SumEvenMoreSumOddSource = new[]
        {
            new object[] { 30, new[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 } }
        };

        [Test]
        public static void SumEvenMoreSumOdd_WhenNumberIsLessOrEqualZero_ShouldThrowException()
        {
            try
            {
                SumEvenMoreSumOdd(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Incorrect number. Numbers should be more than 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        [TestCase(-132, 2, true)]
        [TestCase(111, 1, true)]
        [TestCase(532, 352, true)]
        [TestCase(460, 587, false)]
        [TestCase(-537, -649, false)]
        [TestCase(0, 0, true)]
        [TestCase(0, 406, true)]
        [TestCase(0, 046, false)]
        public static void ContainsSameDigit_WhenNumberNotIsEqualZero_ShouldCalculateResult(int a, int b, bool expectedResult)
        {
            bool actualResult = ContainsSameDigit(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
