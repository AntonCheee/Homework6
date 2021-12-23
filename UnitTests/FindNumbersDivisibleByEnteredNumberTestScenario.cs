using System;
using System.Collections;

namespace UnitTests
{
    public class FindNumbersDivisibleByEnteredNumberTestScenario : IEnumerable
    {
        private const int MAX_VALUE = 1000;
        public IEnumerator GetEnumerator()
        {
            int devider;
            int[] array;
            int[] arrayDeviders = new int[5] { -6, 1, 85, 701, 1000 };

            for (int z = 0; z < 5; z++)
            {
                devider = Math.Abs(arrayDeviders[z]);
                array = new int[MAX_VALUE / devider];

                for (int i = devider, j = 0; i <= MAX_VALUE; i += devider)
                {
                    array[j++] = i;
                }

                yield return new object[] { devider, array };
            }
        }
    }
}
