using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArrayHelper
    {
        public static int FindMinElement(int[] array)
        {
            return array[FindIndexMinElement(array)];
        }

        public static int FindMaxElement(int[] array)
        {
            return array[FindIndexMaxElement(array)];
        }

        public static int FindIndexMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int indexMaxElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indexMaxElement])
                {
                    indexMaxElement = i;
                }
            }

            return indexMaxElement;
        }

        public static int FindIndexMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int indexMinElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[indexMinElement])
                {
                    indexMinElement = i;
                }
            }

            return indexMinElement;
        }

        public static int FindSumOddIndexElements(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int sumOddIndexElements = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sumOddIndexElements += array[i];
            }

            return sumOddIndexElements;
        }

        public static int[] Reverse(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[array.Length - 1 - i]);
            }

            return array;
        }

        public static int CalculateSumOddElements(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int sumOddElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] & 1) != 0)
                {
                    sumOddElements += array[i];
                }
            }

            return sumOddElements;
        }

        public static int[] SwapFirstAndSecondArrayParts(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int additional = array.Length / 2 + array.Length % 2;

            for (int i = 0; i < array.Length / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[i + additional]);
            }

            return array;
        }

        public static int[] MakeSelectionSort(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            var minPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[minPosition] > array[j])
                    {
                        minPosition = j;
                    }
                }

                VariablesHelper.Swap(ref array[i], ref array[minPosition]);

                minPosition = i + 1;
            }

            return array;
        }

        public static int[] MakeInsertSort(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int a = 1; a < array.Length; a++)
            {
                for (int i = a - 1; i >= 0; i--)
                {
                    if (array[a] > array[i])
                    {
                        VariablesHelper.Swap(ref array[a--], ref array[i]);
                    }
                }
            }

            return array;
        }
    }
}
