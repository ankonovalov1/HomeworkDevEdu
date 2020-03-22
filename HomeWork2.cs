using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class HomeWork2
    {

        public static int SumBetweenMinMax(out int max, out int min, int[] array)
        {
            max = array[0];
            min = array[0];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];                    
                }
                
                if (array[i] < min)
                {
                    min = array[i];                    
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum - min - max;

            return sum;


        }

        public static int[] FindElementsLessAverage(int[] array)
        {
            int sum = 0, middleSum, count = 0, index = 0;
            
            for (int i = 0; i < array.Length; i++)            
            {                
                sum += array[i];                
            }
            middleSum = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < middleSum)
                {
                    count++;                    
                }
            }
            
            int[] arrOfElements = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < middleSum)
                {
                    arrOfElements[index] = array[i];
                    index++;
                }
            }

            return arrOfElements;
        }

        public static int[] ChangeArrayElementPosition(int[] array)
        {
            int index;           
           
            int[] array1 = new int[array.Length]; 

            if (array.Length % 2 == 0)
            {
                index = array.Length / 2;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    array1[i] = array[index];
                    index++;                    
                }
            }
            else
            {
                index = array.Length / 2 + 1;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    array1[i] = array[index];
                    index++;                    
                }
            }

            if (array.Length % 2 == 0)
            {
                index = 0;
                for (int i = array.Length / 2; i < array.Length; i++)
                {
                    array1[i] = array[index];
                    index++;                    
                }
            }
            else
            {
                array1[array.Length / 2] = array[array.Length / 2];
                index = 0;
                for (int i = (array.Length / 2) + 1; i < array.Length; i++)
                {
                    array1[i] = array[index];
                    index++;                    
                }
            }
            
            return array1;
        }

        public static int[] DoReverseOfArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];

            int index = arr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[index];
                index--;
            }

            return arr1;
        }

        public static int FindMaxElement(int[] array)
        {
            int max = array[0];            

            for (int i = 0; i < array.Length; i++)
            {                
                if (array[i] > max)
                {
                    max = array[i];                    
                }              

            }            
            return max;
        }

        public static int[] DoFibonachi(int number)
        {
            int sum = 0, a = 1, b;
            int[] arrayFibo = new int[number];

            for (int i = 0; i < number; i++)
            {
                b = sum;
                sum += a;
                a = b;

                arrayFibo[i] = sum;
            }

            return arrayFibo;
        }

        public static int[] DoReverseOfNumber(int number)
        {
            int number1 = number, number2 = number, a, count = 0, index = 0;

            while (number1 > 0)
            {
                number1 /= 10;
                count++;
            }

            int[] reverseNumber = new int[count];

            while (number2 > 0)
            {
                a = number2 % 10;
                number2 /= 10;
                reverseNumber[index] = a;
                index++;
            }
            return reverseNumber;
        }

        public static string FindAGuessedNumber(int number, int guessedNumber, ref int count)
        {
            string message = "";
            if (number != guessedNumber)
            {
                count--;
                if (number > guessedNumber)
                {
                    if (count == 1)
                    {
                        message = $"Ваше число more. Осталось {count} попытка!";
                    }
                    else if (count > 1 && count <= 4)
                    {
                        message = $"Ваше число more. Осталось {count} попытки!";
                    }
                    else if (count > 4)
                    {
                        message = $"Ваше число more. Осталось {count} попыток!";
                    }
                    else if (count == 0)
                    {
                        message = $"Ваше число more. Вы проиграли!";
                    }
                }
                if (number < guessedNumber)
                {
                    if (count == 1)
                    {
                        message = $"Ваше число less. Осталось {count} попытка!";
                    }
                    else if (count > 1 && count <= 4)
                    {
                        message = $"Ваше число less. Осталось {count} попытки!";
                    }
                    else if (count > 4)
                    {
                        message = $"Ваше число less. Осталось {count} попыток!";
                    }
                    else if (count == 0)
                    {
                        message = $"Ваше число less. Вы проиграли!";
                    }
                }

            }
            else if (number == guessedNumber)
            {
                count = 0;
                message = $"Вы угадали! загадано число {number}";
            }
            return message;
        }

        public static double CalcOfTwoNumber(double number1, double number2, string sign)
        {
            double result = 0;

            if (sign == "*")
            {
                result = Math.Round(number1 * number2);
            }
            else if (sign == "/" && number2 != 0)
            {
                result = Math.Round(number1 / number2, 3);
            }
            else if (sign == "+")
            {
                result = number1 + number2;
            }
            else if (sign == "-")
            {
                result = number1 - number2;
            }
            return result;
        }

        
    }
}
