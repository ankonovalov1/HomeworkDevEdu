using System;


namespace Homework
{
    
    
    public class Program
    {

        static void Main(string[] args)
        {
            int a, b, c, d, e;
            DoubleLinkedList alist = new DoubleLinkedList();
            

            alist.AddFirst(9);
            alist.AddFirst(6);
            alist.AddFirst(7);
            alist.AddFirst(7);
            alist.AddFirst(7);
            // 769
            alist.Reverse();

            int[] arr = alist.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }

            Console.WriteLine();






        }
        #region Вторая домашка

        public static void RunDoReverseOfArray()
        {
            int[] arr = new int[] { 3, 5, 6, 7 };
            int[] arr1 = HomeWork2.DoReverseOfArray(arr);
            
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write($" {arr1[i]} ");
            }
        } // Задача 3 Сделать реверс массива

        public static void RunCalcOfTwoNumber()   // Задача 2 Калькулятор
        {
            double number1 = 3, number2 = 7;
            string sign = "/";

            if(number2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
                double result = HomeWork2.CalcOfTwoNumber(number1, number2, sign);

                Console.WriteLine($"Результат дейсвия {number1} {sign} {number2} = {result}");
            }
            

            /*do
            {
                Console.WriteLine("Введите первое число: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знак действия(для выхода из программы введите 0): ");
                sign = Console.ReadLine();

                Console.WriteLine(hw2.CalcOfTwoNumber(number1,number2,sign));
                Console.WriteLine();

            } while (sign != "0");*/

        }

        public static void RunDoReverseOfNumber() // Задача 1 Реверс числа
        {
            int number = 95486;
            int[] result = HomeWork2.DoReverseOfNumber(number);

            Console.WriteLine($"Исходное число: {number}");
            Console.Write("Реверсное число: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($" {result[i]} ");
            }

        }

        public static void RunDoFibonachi() //Ряд Фибоначи Задача 5.
        {
            Console.WriteLine("Введите кол-во элементов ряда: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = HomeWork2.DoFibonachi(number);
            string fibo = "";
            for (int i = 0; i < arr.Length; i++)
            {
                fibo += arr[i];
            }
            Console.WriteLine(fibo);
        }

        public static void RunSumBetweenMinMax()
        {
            int[] arr = new int[] { 3, -7, 12, 46, 33, -14, 2 };

            int sum = HomeWork2.SumBetweenMinMax(out int max, out int min, arr);

            Console.WriteLine($"Сумма элементов массива без min:{min} и max:{max} = {sum}");
        }
        
        public static void RunFindMaxElement()
        {
            int[] arr = new int[] { -10, 50, 6, 3, 15, 87 };
            int max = HomeWork2.FindMaxElement(arr);
            Console.WriteLine($"Максимальный элемент массива: {max}");

        }
        
        public static void RunFindElementsLessAverage()
        {
            int[] arr = new int[] { 3, 14, 2, 7, -11, -32 };
            int[] elements = HomeWork2.FindElementsLessAverage(arr);

            for(int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine($"Элемент {elements[i]} меньше среднего!");
            }
        }
        
        public static void RunFindAGuessedNumber()
        {
            int guessedNumber = 25, count = 10, number;  // Задача 4 Угадать число.
            Console.WriteLine("Загадано число от 0 до 100, отгадай его!");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(HomeWork2.FindAGuessedNumber(number, guessedNumber, ref count));

            } while (count > 0);
        }
        
        public static void RunChangeArrayElementPosition()
        {
            int[] arr = new int[] { 5, 2, 6, 8, 7, 4, 8 };
            int[] result = HomeWork2.ChangeArrayElementPosition(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($" {result[i]} ");
            }
        }






        // Console.WriteLine($"8) {hw2.ChangeArrayElementPosition(rnd.Next(5, 10))}");





        #endregion


        #region Третья домашка        

        public static void RunNumberInSequenceCounter()  //Задача 1:  Посчитать, сколько раз встречается определенная цифра DONE!
        {

            int enter1 = 854685, enter2 = 5;
            Console.WriteLine($"Число {enter2} повторяется: { HomeWork3.NumberInSequenceCounter(enter1, enter2)} раз в числе {enter1} ");
            /*do
                {
                    Console.WriteLine("Enter the length of array");
                    try
                    {
                        enter1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Wrong way, try again!");
                        continue;
                    }

                    Console.WriteLine("Enter the Number");

                    try
                    {
                        enter2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Wrong way, try again!");
                        continue;
                    }

                    Console.WriteLine($"Число {enter2} повторяется: { HomeWork3.NumberInSequenceCounter(enter1, enter2)} раз ");

                } while (enter1 == 0 || enter2 == 0);*/
        }
        
        public static void RunDrawRectangle()    // Задача 2: Вывести на экран прямоугольник.
        {
            int enter1 = 3, enter2 = 3;
            string symbol1 = "+", symbol2 = "-";
            /*do
            {
                Console.WriteLine("Введите кол-во строк:");
                try
                {
                    enter1 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуй еще раз");
                    continue;
                }
                Console.WriteLine("Введите кол-во столбцов:");
                try
                {
                    enter2 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуй еще раз");
                    continue;
                }

            } while (enter1 == 0 || enter2 == 0);

            do
            {
                Console.WriteLine("Введите символ 1:");
                try
                {
                    symbol1 = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуй еще раз");
                    continue;
                }
                Console.WriteLine("Введите символ 2:");
                try
                {
                    symbol2 = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуй еще раз");
                    continue;
                }

            } while (symbol1 == "" || symbol2 == "");*/

            string[,] result = HomeWork3.DrawRectangle(enter1, enter2, symbol1, symbol2);
            for (int i = 0; i < enter1; i++)
            {
                for (int j = 0; j < enter2; j++)
                {
                    Console.Write(result[i,j]);
                }
                Console.WriteLine();
            }
        }  

        public static void RunFindDividersQuantity()     //Задача 3.
        {           
            int enter1 = 1, enter2 = 25, enter3 = 3;
            
            Console.Write($"Sequence: ");
            
            for (int i = enter1; i <= enter2; i++)
            {
                Console.Write($" {i} ");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Number of dividers(not less): {enter3}");
            Console.WriteLine($"{HomeWork3.FindDividersQuantity(enter1, enter2, enter3)} - столько чисел имеют столько {enter3} делителей"); 

        }

        public static void RunChangeValueOfDiagonal() // Задача 5.
        {
            int[,] arr = new int[2, 2] {
                {4, 1 },{-5, -4}
            };
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($" [{arr[i, j], 3}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
              
            int[,] result = HomeWork3.ChangeValueOfDiagonal(arr);            

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($" [{result[i, j], 3}] ");
                }
                Console.WriteLine();
            }
        }    
        
        public static void RunFindQuantityOfBiggerElements() // Задача 6.
        {
            int[,] arr = new int[3, 3]
            {
                {4, 1, 5 },{2, 8, 3},{ 1,3,0 }
            };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    Console.Write($" [{arr[i,j]}] ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine($"Кол-во элементов массива больше его окружающих: {HomeWork3.FindQuantityOfBiggerElements(arr)}");


        }

        public static void RunGame(){ 

            int quantityR = 0, quantityC = 0;
            do
            {
                Console.WriteLine("Enter number of row");

                try
                {
                    quantityR = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong way of row, try again!");
                    continue;
                }

                Console.WriteLine("Enter number of column");
                try
                {
                    quantityC = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong way of column, try again!");
                    continue;
                }

            } while (quantityR == 0 || quantityC == 0);

            int opponentChoose = 0;
            do
            {
                Console.WriteLine("Выберите режим игры!");

                Console.WriteLine("1 - Игра с другом, 2 - Игра с компьютером, 3 - Режим наблюдения : ");

                try
                {
                    opponentChoose = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong way of row, try again!");
                    continue;
                }

            } while (opponentChoose == 0 || opponentChoose > 3);

            string[,] arr = new string[quantityR, quantityC];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = "+";
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            HomeWork3.GameConditions(quantityR, quantityC, opponentChoose, arr); 

        } //  Задача 4. Игра

        #endregion
               

        #region Первая домашка

        public static void RunCalcCreditPayments()
        {
            double[] arr = HomeWork1.CalcCreditPayments(30000, 9, 30);
            Console.WriteLine($"{arr[0]}, {arr[1]}");
        }

        public static void RunLengthOfHypo()
        {
            Console.WriteLine($"2) Длина гипотенузы: {HomeWork1.LengthOfHypo(5, 5)}");
        }
        public static void RunMathResult()
        {
            Console.WriteLine($"5) Посчитать выражение: {HomeWork1.MathResult(15, 0, 2)}");
        }
        public static void RunFactorialOfNumber()
        {
            Console.WriteLine($"9) Факториал: {HomeWork1.FactorialOfNumber(5)}");
        }
        public static void RunDotPosition()
        {

            int result = HomeWork1.DotPosition(5, 5);

            if (result == 0)
            {
                Console.WriteLine($"Точка лежит на оси координат!");
            }
            else if (result == 1)
            {
                Console.WriteLine($"Точка лежит в I квадранте!");
            }
            else if (result == 2)
            {
                Console.WriteLine($"Точка лежит в II квадранте!");
            }
            else if (result == 3)
            {
                Console.WriteLine($"Точка лежит в III квадранте!");
            }
            else if (result == 4)
            {
                Console.WriteLine($"Точка лежит в IV квадранте!");
            }

        }
        public static void RunSumAndMultiOfNumber()
        {
            int[] arr = HomeWork1.SumAndMultiOfNumber(548965);
            Console.WriteLine($"11) Сумма {arr[0]}, произведение {arr[1]} ");
        }

        public static void RunIsTrueExpression()
        {
            int[] result = HomeWork1.IsTrueExpression(20);
            Console.WriteLine($"12) Решение доказано {result[0]} раз из 10, опровергнуто {result[1]} из 10");
        }

        public static void RunIsDotInsideOfCircle()
        {
            int result = HomeWork1.IsDotInsideOfCircle(-1, 7, 3);
            if (result == 0)
            {
                Console.WriteLine("Решения нет!");
            }
            else
            {
                if (result == 1)
                {
                    Console.WriteLine("Точка лежит в пределах окружности!!");
                }
                else if (result == 2)
                {
                    Console.WriteLine("Точка лежит не в пределах окружности!");
                }
                else if (result == 3)
                {
                    Console.WriteLine("Точка лежит на окружности!");
                }
            }
        }

        public static void RunStraightLineEquation()
        {
            int[] result = HomeWork1.StraightLineEquation(2, 0, 0, 2);

            if (result[1] < 0)
            {
                Console.WriteLine($"уравнение прямой : y = {result[0]}x  {result[1]}");
            }
            else if (result[0] == 0)
            {
                Console.WriteLine($"уравнение прямой : y = {result[1]}");
            }
            else if (result[1] == 0)
            {
                Console.WriteLine($"уравнение прямой : y = {result[0]}x ");
            }
            else
            {
                Console.WriteLine($"уравнение прямой : y = {result[0]}x + {result[1]}");
            }
        }

        public static void RunFindSquareRoots()
        {
            int a = -1, b = 2, c = 3;
            if (a != 0)
            {
                double[] result = HomeWork1.FindSquareRoots(a, b, c, out double discriminant);


                if (discriminant < 0)
                {
                    Console.WriteLine($"Уравнение не имеет корней, дискриминант равен {discriminant}");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine($"Уравнение имеет один корень : {result[0]} и дискриминант {discriminant}");

                }
                else if (discriminant > 0)
                {
                    Console.WriteLine($"Уравнение имеет два корня : {result[0]} и {result[1]} и дискриминант {discriminant} ");

                }
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решения!");
            }

        }

        public static void RunIsTrueFirstDivideOnSecond()
        {
            int firstNumber = 5, secondNumber = 2;
            bool result = HomeWork1.IsTrueFirstDivideOnSecond(firstNumber, secondNumber, out int[] arr);
            if (result == false && secondNumber == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else if (result == true && secondNumber == firstNumber)
            {
                Console.WriteLine("Результатом деления двух равных чисел является: 1");
            }

            if (result == true && arr[1] == 0)
            {
                Console.WriteLine($"Число {firstNumber} делится на {secondNumber} без остатка. Результат деления: {arr[0]}");

            }
            else if (result == true && arr[1] != 0)
            {
                Console.WriteLine($"Число {firstNumber} делится на {secondNumber} c остатком. Результат деления: {arr[0]} в остатке {arr[1]}");

            }

        }

        public static void RunValueYOfX()
        {
            int min = -5, max = 5, step = 3;
            double[,] arr = HomeWork1.ValueYOfX(min, max, step);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Значение функции y = -0.23x^2 + x от x: {arr[i, 0]} равно {arr[i, 1]}");
            }            
        }

        #endregion
    }
}

