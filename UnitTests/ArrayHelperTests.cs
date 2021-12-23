using System;
using NUnit.Framework;
using static ClassLibrary.ArrayHelper;

namespace UnitTests
{
    class ArrayHelperTests
    {
        static object[] FindMinElementSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -1, 1000 }, -9 },
            new object[] { new[] { 10, 5, 9, 73, 16, 100, 10, 7 }, 5 },
            new object[] { new[] { 10, 5, 9, 73, 0, 19, 1, 10 }, 0 },
        };

        [TestCaseSource(nameof(FindMinElementSource))]
        public static void FindMinElement_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = FindMinElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void FindMinElement_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                FindMinElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindMaxElementSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -1, 100 }, 100 },
            new object[] { new[] { 101, 5, 9, 73, 16, 100, 10, 1 }, 101 },
            new object[] { new[] { -5, -9, -73, 0, -19, -1, -10 }, 0 },
        };

        [TestCaseSource(nameof(FindMaxElementSource))]
        public static void FindMaxElement_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = FindMaxElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void FindMaxElement_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                FindMaxElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindIndexMinElementSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -1, 1000 }, 0 },
            new object[] { new[] { 10, 5, 9, 73, 16, 100, 10, 1 }, 7 },
            new object[] { new[] { 10, 5, 9, 73, 0, 19, 1, 10 }, 4 },
        };

        [TestCaseSource(nameof(FindIndexMinElementSource))]
        public static void FindIndexMinElement_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = FindIndexMinElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void FindIndexMinElement_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                FindIndexMinElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindIndexMaxElementSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -1, 100 }, 7 },
            new object[] { new[] { 101, 5, 9, 73, 16, 100, 10, 1 }, 0 },
            new object[] { new[] { -5, -9, -73, 0, -19, -1, -10 }, 3 },
        };

        [TestCaseSource(nameof(FindIndexMaxElementSource))]
        public static void FindIndexMaxElement_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = FindIndexMaxElement(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void FindIndexMaxElement_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                FindIndexMaxElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] FindSumOddIndexElementsSource = new[]
        {
            new object[] { new[] {-9, 5, -4, 73, 19, 0, -1, 100}, 178 },
            new object[] { new[] { 101, 5, 9, 73, 16, 100, 10, -178}, 0 },
            new object[] { new[] { -5, -9, -73, 0, -19, -1, -10, 3}, -7 },
        };

        [TestCaseSource(nameof(FindSumOddIndexElementsSource))]
        public static void FindSumOddIndexElements_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = FindSumOddIndexElements(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void FindSumOddIndexElements_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                FindSumOddIndexElements(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] ReverseSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -1, 100 }, new[] { 100, -1, 0, 19, 73, -4, 5, -9 } },
            new object[] { new[] { 101, 5, 9, 73, 16, 100, 10, -178 }, new[] { -178, 10, 100, 16, 73, 9, 5, 101 } },
            new object[] { new[] { -5, -9, -73, 0, -19, -1, -10, 3, -7 }, new[] {-7, 3, -10, -1, -19, 0, -73, -9, -5 }}
        };

        [TestCaseSource(nameof(ReverseSource))]
        public static void Reverse_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int[] expectedResult)
        {
            int[] actualResult = Reverse(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void Reverse_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                Reverse(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] CalculateSumOddElementsSource = new[]
        {
            new object[] { new[] { -9, 5, -4, 73, 19, 0, -98, 100 }, 88 },
            new object[] { new[] { 101, 5, 9, 73, 16, 100, 10, -178 }, 188 },
            new object[] { new[] { -4, -9, -74, 0, -19, -1, -10, 3}, -26 },
            new object[] { new int[] { }, 0}
        };

        [TestCaseSource(nameof(CalculateSumOddElementsSource))]
        public static void CalculateSumOddElements_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int expectedResult)
        {
            int actualResult = CalculateSumOddElements(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void CalculateSumOddElements_WhenArrayIsNull_ShouldThrowException()
        {
            try
            {
                CalculateSumOddElements(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }


        static object[] SwapFirstAndSecondArrayPartsSource = new[]
        {
            new object[] { new[] { 1 }, new[] { 1 } },
            new object[] { new[] { 1, 2 }, new[] { 2, 1 } },
            new object[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } },
            new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 1, 2 } },
            new object[] { new[] { 1, 2, 3, 4, 5, 6 }, new[]  { 4, 5, 6, 1, 2, 3 } },
            new object[] { new int[] { }, new int[]  { } }
        };

        [TestCaseSource(nameof(SwapFirstAndSecondArrayPartsSource))]
        public static void SwapFirstAndSecondArrayParts_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int[] expectedResult)
        {
            int[] actualResult = SwapFirstAndSecondArrayParts(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void SwapFirstAndSecondArrayParts_WhenArrayIsNull_ShouldThrowException()
        {
            try
            {
                SwapFirstAndSecondArrayParts(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }


        static object[] MakeSelectionSortSource = new[]
        {
            new object[] { new[] { 1, -3, 0, 16, -78, 100, 4 }, new[] { -78, -3, 0, 1, 4, 16, 100 } },
            new object[] { new[] { 7, 5, 5, 7, 3, 2, 6, 0 }, new[] { 0, 2, 3, 5, 5, 6, 7, 7 } }
        };

        [TestCaseSource(nameof(MakeSelectionSortSource))]
        public static void MakeSelectionSort_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int[] expectedResult)
        {
            int[] actualResult = MakeSelectionSort(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void MakeSelectionSort_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                MakeSelectionSort(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }

        static object[] MakeInsertSortSource = new[]
        {
            new object[] { new[] { 1, -3, 0, 16, -78, 100, 4 }, new[] { 100, 16, 4, 1, 0, -3, -78 } },
            new object[] { new[] { 7, 5, 5, 7, 3, 2, 6, 0 }, new[] { 7, 7, 6, 5, 5, 3, 2, 0 } }
        };

        [TestCaseSource(nameof(MakeInsertSortSource))]
        public static void MakeInsertSort_WhenArrayNotEmpty_ShouldFindMinElement(int[] array, int[] expectedResult)
        {
            int[] actualResult = MakeInsertSort(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public static void MakeInsertSort_WhenArrayIsEmpty_ShouldThrowException(int[] array)
        {
            try
            {
                MakeInsertSort(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail("No throw exception");
        }
    }
}
