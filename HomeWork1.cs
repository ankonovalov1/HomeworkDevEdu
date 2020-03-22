using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class HomeWork1
    {
        public static double[] CalcCreditPayments(int sumOfCredit, int year, double procent)
        {
            double p1 = procent / 100;

            double monthlyPayment = Math.Round((sumOfCredit * p1 * (1 + p1) * year) / (12 * (1 + p1) * (year - 1)), 2);
            double sumOfPayments = Math.Round((monthlyPayment * 12) * year, 2);

            double[] result = new double[2] { monthlyPayment, sumOfPayments };

            return result;

        }

        public static double LengthOfHypo(double a, double b)
        {
            double length = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return Math.Round(length, 3);
        }

        public static int[] StraightLineEquation(int dotX1, int dotY1, int dotX2, int dotY2)
        {
            int k = (dotY1 - dotY2) / (dotX1 - dotX2);  // Уравнение прямой y = kx + b
            int b = dotY2 - k * dotX2;

            int[] arr = new int[] { k, b };
            return arr;

        }

        public static double[] FindSquareRoots(int a, int b, int c, out double discriminant) // уравнение вида {a}x^2 + {b}x + {c}
        {

            double rootOne, rootTwo;
            double[] arr = new double[2];
            
            
            discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (discriminant < 0)
            {

                arr[0] = discriminant;
            }
            else if  (discriminant == 0)
            {
                
                rootOne = Math.Round(((-b + Math.Sqrt(discriminant)) / (2 * a)), 3);
                
                arr[0] = rootOne;
                arr[1] = rootOne;

            }
            else if (discriminant > 0)
            {
                rootOne = Math.Round(((-b + Math.Sqrt(discriminant)) / (2 * a)), 3);
                rootTwo = Math.Round(((-b - Math.Sqrt(discriminant)) / (2 * a)), 3);
                arr[0] = rootOne;
                arr[1] = rootTwo;

            }

            return arr;
        }

        public static int MathResult(int number1, int number2, int number3)


        {
            int sum = number1 + number2 + number3;
            int multi = number1 * number2 * number3;
            int result;

            if (sum > multi)
            {
                result = sum + 3;
            }
            else
            {
                result = multi + 3;
            }

            return result;
        }

        public static bool IsTrueFirstDivideOnSecond(int firstNumber, int secondNumber, out int[] arr)
        {
            int remOfDivision, numResult;            
            bool result = false;
            arr = new int[2];
            if(secondNumber == 0)
            {
                
                return result;
            }
            numResult = firstNumber / secondNumber;
            remOfDivision = firstNumber % secondNumber;
            arr[0] = numResult;
            arr[1] = remOfDivision;

            result = true;
            return result;
        }

        public static int DotPosition(int dotX, int dotY)
        {

            int result = 0;

            if (dotX == 0 || dotY == 0)
            {
                result = 0;
            }
            else if (dotX > 0 && dotY > 0)
            {
                result = 1;
            }
            else if (dotX < 0 && dotY > 0)
            {
                result = 2;
            }
            else if (dotX < 0 && dotY < 0)
            {
                result = 3;
            }
            else if (dotX > 0 && dotY < 0)
            {
                result = 4;
            }

            return result;
        }

        public static int IsDotInsideOfCircle(int dotX, int dotY, int radius)
        {
            int x1 = 0, y1 = 0;                // x1,y1 - координаты точки начала оси координат.
            double d;                          // Длина отрезка от начала координат до данной точки.
            string condition = $"Точка имеет координаты x: {dotX}, y: {dotY}. Окружность имеет радиус: {radius}";
            int result = 0;

            if (radius <= 0)
            {
                result = 0;
            }
            else if (radius > 0)
            {
                d = Math.Sqrt(Math.Pow((dotX - x1), 2) + Math.Pow((dotY - y1), 2));
                if (radius > d)
                {
                    result = 1;
                }
                else if (radius < d)
                {
                    result = 2;
                }
                else if (radius == d)
                {
                    result = 3;
                }
            }

            return result;
        }

        public static int FactorialOfNumber(int number)
        {

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int[] IsTrueExpression(int number)
        {
            int totalCount = 0;
            int count = 0, count1 = 0;
            do
            {
                int sum = 0, multi = number * (number + 1) / 2;

                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                if (sum == multi)
                {
                    count++;
                }
                else
                {
                    count1++;
                }

                totalCount++;
            } while (totalCount < 10);

            int[] result = new int[] { count, count1 };

            return result;
        }

        public static int[] SumAndMultiOfNumber(int number)
        {
            int number1 = number, a, b, sum = 0, multi = 1;
            int[] arr = new int[2];

            while (number1 > 0)
            {
                a = number1 % 10;
                b = a;
                number1 /= 10;
                sum += a;
                multi *= b;
            }

            arr[0] = sum;
            arr[1] = multi;

            return arr;

        }

        public static double[,] ValueYOfX(int min, int max, int step)
        {
            int x, index = 0, rowlength = (max - min) / step + 1;
            double sqrX, y;            
            double[,] result = new double[rowlength, 2];


            for (int i = min; i < max; i += step)
            {
                x = i;
                sqrX = Math.Pow(x, 2);
                y = Math.Round((-0.23) * sqrX + x, 3);                
                min += step;
                result[index, 0] = x;
                result[index, 1] = y;
                index++;

            }
            return result;
        }
    }

}
