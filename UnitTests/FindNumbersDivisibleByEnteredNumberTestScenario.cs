using System;
using System.Collections;

namespace UnitTests
{
    public class FindNumbersDivisibleByEnteredNumberTestScenario : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int devider;
            int[] array;
            int[] arrayDeviders = new int[5] { -6, 1, 85, 701, 1000 };

            for (int z = 0; z < 5; z++)
            {
                devider = Math.Abs(arrayDeviders[z]);
                array = new int[1000 / devider];

                for (int i = devider, j = 0; i <= 1000; i += devider)
                {
                    array[j++] = i;
                }

                yield return new object[] { devider, array };
            }
        }
    }
}
