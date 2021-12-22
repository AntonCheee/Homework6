using System;

namespace ClassLibrary
{
    public class TwoDimensionalArrayHelper
    {
        public static int FindMinElement(int[,] array)
        {
            (int i, int j) = FindIndexMinElement(array);

            return array[i, j];
        }

        public static int FindMaxElement(int[,] array)
        {
            (int i, int j) = FindIndexMaxElement(array);

            return array[i, j];
        }

        public static (int, int) FindIndexMinElement(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Two-dimensional array is empty");
            }

            (int, int) indexMaxElement = (0, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexMaxElement.Item1, indexMaxElement.Item2] > array[i, j])
                    {
                        indexMaxElement = (i, j);
                    }
                }
            }

            return indexMaxElement;
        }

        public static (int, int) FindIndexMaxElement(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Two-dimensional array is empty");
            }

            (int, int) indexMinElement = (0, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexMinElement.Item1, indexMinElement.Item2] < array[i, j])
                    {
                        indexMinElement = (i, j);
                    }

                }
            }

            return indexMinElement;
        }

        public static int FindElementMoreThanAllNeighbor(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Two-dimensional array is empty");
            }

            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && array[i, j] <= array[i - 1, j])
                    {
                        continue;
                    }
                    if (i < array.GetLength(0) - 1 && array[i, j] <= array[i + 1, j])
                    {
                        continue;
                    }
                    if (j > 0 && array[i, j] <= array[i, j - 1])
                    {
                        continue;
                    }
                    if (j < array.GetLength(1) - 1 && array[i, j] <= array[i, j + 1])
                    {
                        continue;
                    }

                    count++;
                }
            }

            return count;
        }

        public static int[,] ReflectElementsRelativeToDiagonal(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Two-dimensional array is empty");
            }

            if (array.GetLength(0) != array.GetLength(1))
            {
                throw new ArgumentException("Two-dimensional array should be square");
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    VariablesHelper.Swap(ref array[i, j], ref array[j, i]);
                }
            }

            return array;
        }
    }
}