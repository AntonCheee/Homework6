using System;
using NUnit.Framework;
using static ClassLibrary.TwoDimensionalArrayHelper;

namespace UnitTests
{
    class TwoDimensionalArrayHelperTests
    {
        static object[] FindMinElementSource = new[]
         {
            new object[] { new[,] { { -9, 5, 4 }, { 73, 19, 0 }, { -1, 1000, 51 } }, -9 },
            new object[] { new[,] { { 10, 7, 9 }, { 73, 16, 100 }, { 10, 7, 5 } }, 5 },
            new object[] { new[,] { { 10, 5, 9 }, { 0, 73, 19 } }, 0 }
        };

        [TestCaseSource(nameof(FindMinElementSource))]
        public static void FindMinElement_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, int expectedResult)
        {
            int actualResult = FindMinElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindMinElement_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                FindMinElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindMaxElementSource = new[]
        {
            new object[] { new[,] { { -9, 5, -4 }, { 73, 19, 0 }, { -1, 100, 99 } }, 100 },
            new object[] { new[,] { { 101, 5, 9 }, { 73, 16, 100 }, { 10, 1, 99 } }, 101 },
            new object[] { new[,] { { -5, -9, -73 }, { 0, -19, -1 } }, 0 },
        };

        [TestCaseSource(nameof(FindMaxElementSource))]
        public static void FindMaxElement_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, int expectedResult)
        {
            int actualResult = FindMaxElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindMaxElement_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                FindMaxElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindIndexMinElementSource = new[]
        {
            new object[] { new[,] { { -9, 5, -4 }, { 73, 19, 0 }, { -1, 1000, 453 } }, (0, 0) },
            new object[] { new[,] { { 10, 5, 9 }, { 73, 16, 100 }, { 10, 1, 2 } }, (2, 1) },
            new object[] { new[,] { { 10, 5, 9 }, { 0, 73, 19 } }, (1, 0) },
        };

        [TestCaseSource(nameof(FindIndexMinElementSource))]
        public static void FindIndexMinElement_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, (int, int) expectedResult)
        {
            (int, int) actualResult = FindIndexMinElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindIndexMinElement_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                FindIndexMinElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindIndexMaxElementSource = new[]
        {
            new object[] { new[,] { { -9, 5, -4 }, { 73, 19, 0 }, { -1, 100, 99 } }, (2, 1) },
            new object[] { new[,] { { 101, 5, 9 }, { 73, 16, 100 }, { 10, 1, 52 } }, (0, 0) },
            new object[] { new[,] { { -5, -9, -73 }, { -19, 0, -1 } }, (1, 1) },
        };

        [TestCaseSource(nameof(FindIndexMaxElementSource))]
        public static void FindIndexMaxElement_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, (int, int) expectedResult)
        {
            (int, int) actualResult = FindIndexMaxElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindIndexMaxElement_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                FindIndexMaxElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindElementMoreThanAllNeighborSource = new[]
        {
            new object[] { new[,] { { 5, 4, 9 }, { 2, 1, 6 }, { 6, 5, 7 } }, 4 },
            new object[] { new[,] { { 4, 5, 3 }, { 6, 2, 7 }, { 5, 8, 1 } },  4  },
            new object[] { new[,] { { 4, 5, 6 }, { 1, 9, 8 }, { 4, 5, 6 } }, 1 },
            new object[] { new[,] { { 4, 5, 6 }, { 1, 8, 8 }, { 4, 5, 6 } }, 0 },
            new object[] { new[,] { { 5, 2 }, { 3, 4 } }, 2 },
        };

        [TestCaseSource(nameof(FindElementMoreThanAllNeighborSource))]
        public static void FindElementMoreThanAllNeighbor_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, int expectedResult)
        {
            int actualResult = FindElementMoreThanAllNeighbor(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void FindElementMoreThanAllNeighbor_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                FindElementMoreThanAllNeighbor(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] ReflectElementsRelativeToDiagonalSource = new[]
        {
            new object[] { new[,] { { 5, 4, 9 }, { 2, 1, 6 }, { 6, 5, 7 } },  new[,] { { 5, 2, 6 }, { 4, 1, 5 }, { 9, 6, 7 } }},
            new object[] { new[,] { { 1, 4, 5}, {4, 2, 6}, {5, 6, 3} },   new[,] { { 1, 4, 5}, {4, 2, 6}, {5, 6, 3} } },
            new object[] { new[,] { { 5, 2 }, { 3, 4 } }, new[,] { { 5, 3 }, { 2, 4 } } },
        };

        [TestCaseSource(nameof(ReflectElementsRelativeToDiagonalSource))]
        public static void ReflectElementsRelativeToDiagonal_WhenArrayNotEmpty_ShouldFindMinElement(int[,] array, int[,] expectedResult)
        {
            int[,] actualResult = ReflectElementsRelativeToDiagonal(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void ReflectElementsRelativeToDiagonal_WhenArrayIsEmpty_ShouldThrowException()
        {
            try
            {
                ReflectElementsRelativeToDiagonal(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] ReflectElementsRelativeToDiagonalExceptionSource = new[]
       {
            new object[] { new[,] { { 5, 4, 9 }, { 2, 1, 6 }, }},
            new object[] { new[,] { { 1, 4, 5} } },
            new object[] { new[,] { { 5 }, { 3 } } },
        };

        [TestCaseSource(nameof(ReflectElementsRelativeToDiagonalExceptionSource))]
        public static void ReflectElementsRelativeToDiagonal_WhenTwoDimensionalArrayIsNotSquare_ShouldThrowException(int[,] array)
        {
            try
            {
                ReflectElementsRelativeToDiagonal(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Two-dimensional array should be square", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }
    }
}
