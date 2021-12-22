using System;

namespace ClassLibrary
{
    public class ConditionalOperatorsHelper
    { public static double MathOperationAfterComparingNumbers(double a, double b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }

            return result;
        }

        public static int FindingQuadrantOfPoint(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("The point is on the coordinate axis");
            }

            int result;

            switch (x, y)
            {
                case ( > 0, > 0):
                    result = 1;
                    break;
                case ( > 0, < 0):
                    result = 2;
                    break;
                case ( < 0, < 0):
                    result = 3;
                    break;
                case ( < 0, > 0):
                    result = 4;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public static (int, int, int) OrderThreeNumber(int a, int b, int c)
        {
            if (a > b)
            {
                VariablesHelper.Swap(ref a, ref b);
            }
            if (a > c)
            {
                VariablesHelper.Swap(ref a, ref c);
            }
            if (b > c)
            {
                VariablesHelper.Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        public static (double, double) SolvingQuadraticEquations(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("There is no solution of quadratic equation for A = 0");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new ArgumentException("There is no solution of quadratic equation");
            }

            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return (x1, x2);
        }

        public static string ConvertNumberIntoWords(int number)
        {
            string textValue = string.Empty;

            if (number >= 10 && number <= 19)
            {
                switch (number)
                {
                    case 10:
                        textValue = "ten";
                        break;
                    case 11:
                        textValue = "eleven";
                        break;
                    case 12:
                        textValue = "twelve";
                        break;
                    case 13:
                        textValue = "thirteen";
                        break;
                    case 14:
                        textValue = "fourteen";
                        break;
                    case 15:
                        textValue = "fifteen";
                        break;
                    case 16:
                        textValue = "sixteen";
                        break;
                    case 17:
                        textValue = "seventeen";
                        break;
                    case 18:
                        textValue = "eighteen";
                        break;
                    case 19:
                        textValue = "nineteen";
                        break;
                }
            }
            else
            {
                int tens = number / 10;
                int units = number % 10;

                switch (tens)
                {
                    case 2:
                        textValue += "twenty";
                        break;
                    case 3:
                        textValue += "thirty";
                        break;
                    case 4:
                        textValue += "forty";
                        break;
                    case 5:
                        textValue += "fifty";
                        break;
                    case 6:
                        textValue += "sixty";
                        break;
                    case 7:
                        textValue += "seventy";
                        break;
                    case 8:
                        textValue += "eighty";
                        break;
                    case 9:
                        textValue += "ninety";
                        break;
                }

                switch (units)
                {
                    case 1:
                        textValue += "-one";
                        break;
                    case 2:
                        textValue += "-two";
                        break;
                    case 3:
                        textValue += "-three";
                        break;
                    case 4:
                        textValue += "-four";
                        break;
                    case 5:
                        textValue += "-five";
                        break;
                    case 6:
                        textValue += "-six";
                        break;
                    case 7:
                        textValue += "-seven";
                        break;
                    case 8:
                        textValue += "-eight";
                        break;
                    case 9:
                        textValue += "-nine";
                        break;
                    default:
                        textValue += string.Empty;
                        break;
                }
            }

            return textValue;
        }
    }
}
