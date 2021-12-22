using System;

namespace ClassLibrary
{
    public class LoopsHelper
    {
        public static double Exponentiate(double number, int degree)
        {
            double result = 1;

            for (int i = 1; i <= degree; i++)
            {
                result *= number;
            }

            return result;
        }

        public static int[] FindNumbersDivisibleByEnteredNumber(int number)
        {
            int countNumber = 0;
            int rangeMinValue = number;
            int rangeMaxValue = 1000;

            if (number == 0)
            {
                throw new DivideByZeroException("Number can not be equal 0");
            }

            for (int i = rangeMinValue; i <= rangeMaxValue; i += number)
            {
                ++countNumber;
            }

            int[] resultList = new int[countNumber];

            rangeMinValue = number;

            for (int i = rangeMinValue, j = 0; i <= rangeMaxValue; i += number, j++)
            {
                resultList[j] = i;
            }

            return resultList;
        }

        public static int PowerCount(double a)
        {
            int i = 0;

            while (a > 0)
            {
                if (i * i >= a)
                {
                    i--;
                    break;
                }

                i++;
            }

            return i;
        }

        public static int MaxDivider(int a)
        {
            int i;
            int n = 0;

            if(a ==-1 || a == 0 || a == 1)
            {
                throw new ArgumentException($"There are no solution for number = {a}");
            }

            for (i = Math.Abs(a) / 2; i >= 1; i--)
            {
                n++;

                if (a % i == 0)
                {
                    break;
                }
            }

            return i;
        }

        public static int SumFromAToB(int a, int b)
        {
            if (a < 0 || b < 0) 
            {
                throw new ArgumentException("Incorrect number. Numbers should be more or equal 0");
            }

            if (a > b)
            {
                VariablesHelper.Swap(ref a, ref b);
            }

            int result = 0;

            if (a % 7 != 0)
            {
                a += 7 - a % 7;
            }            

            for (int i = a; i <= b; i += 7)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int FibonacciSequence(int position)
        {
            if (position <= 0)
            {
                throw new ArgumentException("Incorrect number. Numbers should be more than 0");
            }

            int n1 = 1;
            int n2 = 1;
            int n = 0;

            if (position == 1 || position == 2) 
            {
                return n1;
            }            

            for (int i = 2; i < position; i++)
            {
                n = n1 + n2;
                n1 = n2;
                n2 = n;
            }

            return n;
        }

        public static int EuclideanAlgorithm(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Incorrect number. Numbers should be more or equal 0");
            }

            if (a < b)
            {
                VariablesHelper.Swap(ref a, ref b);
            }

            int result = 1;

            if(b != 0) {
                while (true)
                {
                    int remainder = a % b;

                    a = b;
                    b = remainder;

                    if (remainder == 0)
                    {
                        result = a;
                        break;
                    }
                }
            }

            return result;
        }

        public static double HalfDivisionMethod(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Incorrect number. Numbers should be more than 0");
            }

            double rangeStart = 0;
            double rangeEnd = 1;

            do
            {
                if ((rangeEnd * rangeEnd * rangeEnd) < number)
                {
                    rangeStart = rangeEnd;
                    ++rangeEnd;
                }
                else
                {
                    break;
                }
            }
            while (true);

            double precision;
            double result;

            do
            {
                result = (rangeStart + rangeEnd) / 2;
                precision = Math.Abs(result * result * result - number);

                if (((rangeStart * rangeStart * rangeStart - number) * (result * result * result - number)) > 0)
                {
                    rangeStart = result;
                }
                else
                {
                    rangeEnd = result;
                }
            }
            while (precision > 0.0001);

            result = Math.Round(result, 4);

            return result;
        }

        public static int CountOddNumber(int number)
        {
            if (number == 0)
            {
                throw new ArgumentException("Incorrect number. Numbers can not be 0");
            }

            int numberAbs = Math.Abs(number);
            int countOddDigits = 0;

            while (numberAbs != 0)
            {
                if (numberAbs % 10 % 2 == 1)
                {
                    ++countOddDigits;
                }

                numberAbs /= 10;
            };

            return countOddDigits;
        }

        public static int Reverse(int number)
        {
            int reversedNumber = 0;
            bool isNegative = number < 0 ? true : false;
            number = isNegative ? Math.Abs(number) : number;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            };

            reversedNumber = isNegative ? reversedNumber * (-1) : reversedNumber;

            return reversedNumber;
        }

        public static int[] SumEvenMoreSumOdd(int enteredNumber)
        {
            if (enteredNumber <= 0)
            {
                throw new ArgumentException("Incorrect number. Numbers should be more than 0");
            }

            var totalEvenNumber = 0;

            for (int i = 1; i <= enteredNumber; i++)
            {
                int countEven = 0;
                int countOdd = 0;
                int number = i;

                do
                {
                    int reminder = number % 10;

                    if (reminder % 2 == 0)
                    {
                        countEven += reminder;
                    }
                    else
                    {
                        countOdd += reminder;
                    }
                    number = number / 10;
                }
                while (number != 0);

                if (countEven > countOdd)
                {
                    ++totalEvenNumber;
                }
            }

            int[] listEvenNumbers = new int[totalEvenNumber];
            int listPosition = 0;

            for (int i = 1; i <= enteredNumber; i++)
            {
                int countEven = 0;
                int countOdd = 0;
                int number = i;

                do
                {
                    int reminder = number % 10;

                    if (reminder % 2 == 0)
                    {
                        countEven+=reminder;
                    }
                    else
                    {
                        countOdd += reminder;
                    }
                    number = number / 10;
                }
                while (number != 0);

                if (countEven > countOdd)
                {
                    listEvenNumbers[listPosition++] = i;
                }
            }

            return listEvenNumbers;
        }

        public static bool ContainsSameDigit(int number1, int number2)
        {
            int number1Abs = Math.Abs(number1);
            int number2Abs = Math.Abs(number2);
            bool result = false;

            while (number1Abs > 0 )
            {
                int tempNumber2 = number2Abs;
                int remainder1 = number1Abs % 10;

                while (tempNumber2 > 0)
                {
                    int remainder2 = tempNumber2 % 10;

                    if (remainder1 == remainder2)
                    {
                        result = true;
                        break;
                    }

                    tempNumber2 /= 10;
                };

                number1Abs /= 10;
            };

            return result;
        }
    }
}