using System;

namespace Homework6
{
    class Program
    {
        static void Main()
        {
            static void Main(string[] args)
            {
                double a;
                double b;
                bool convertionResult;

                do
                {
                    convertionResult = double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b);
                }
                while (!convertionResult);
            }
        }
    }
}
