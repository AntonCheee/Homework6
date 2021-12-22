using System;

namespace ClassLibrary
{
    public class VariablesHelper
    {
        public static double CalculateEquation(double number1, double number2)
        { 
            if(number1 == number2)
            {
                throw new ArgumentException("Numbers are same");
            }

            double result = (5 * number1 + number2 * number2) / (number2 - number1);

            return result;
        }

        public static void Swap(ref double number1, ref double number2)
        {
            double temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static double Divide(int dividend, int divisor)
        {
            if (divisor == 0) 
            {
                throw new DivideByZeroException("Divisor is equal 0");
            }
            double remainder = (double)dividend / divisor;

            return remainder;
        }

        public static int GetRemainderOfDivision(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor is equal 0");
            }

            int remainder = dividend % divisor;

            return remainder;
        }

        public static double CalculationOfLinearEquationOfStandardForm(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Divisor is equal 0");
            }

            double x = (c - b) / a;

            return x;
        }

        public static string CalculateEquationOfLineByTwoPoints(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new ArgumentException("x1 equals x2");
            }

            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            string equation = $"Y= {a}*X + {b}";

            return equation;
        }
    }
}
