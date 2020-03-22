using System;
using System.Collections.Generic;
using System.Text;

namespace Homework

{
    public class HomeWork3
    {
        public static string[] romanAlphabet = new string[] {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public static int[] arabicAlternative = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public static int NumberInSequenceCounter(int enter1, int enter2)
        {
            int enter = enter1, a;
            int count1 = 0;
            int result;

            while (enter > 0)
            {
                a = enter % 10;
                enter /= 10;

                if (a == enter2)
                {
                    count1++;
                }
            }
            result = count1;
            return result;
        }

        public static string[,] DrawRectangle(int enter1, int enter2, string symbol1, string symbol2)
        {
            string[,] arr = new string[enter1, enter2];

            for (int i = 0; i < enter1; i++)
            {
                for (int j = 0; j < enter2; j++)
                {
                    if (i == 0 || i == enter1 - 1 || j == 0 || j == enter2 - 1)
                    {
                        arr[i, j] = symbol1;
                    }
                    else
                    {
                        arr[i, j] = symbol2;
                    }

                }

            }
            return arr;
        }

        public static int FindDividersQuantity(int enter1, int enter2, int enter3)
        {
            int count = 0, countOfNumber = 0;

            for (int i = enter1; i <= enter2; i++)
            {
                int count1 = count;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count1++;
                    }
                }
                if (count1 >= enter3)
                {
                    countOfNumber++;
                }
            }
            return countOfNumber;
        }

        public static int[,] ChangeValueOfDiagonal(int[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);
            int indexRow = arr.GetLength(0) - 1;
            int indexColumn = arr.GetLength(1) - 1;

            if (row > 2 && column > 2)
            {
                for (int i = 0; i < row / 2; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (i == j)
                        {
                            int middle = arr[i, j];
                            arr[i, j] = arr[i, indexColumn];
                            arr[i, indexColumn] = middle;
                            indexColumn--;
                        }
                    }
                }

                for (int i = row / 2; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (i + j == indexRow)
                        {
                            int middle = arr[i, j];
                            arr[i, j] = arr[i, indexColumn];
                            arr[i, indexColumn] = middle;
                            indexColumn++;
                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {                        
                            int middle = arr[i, j];
                            arr[i, j] = arr[i, indexColumn];
                            arr[i, indexColumn] = middle;
                                                    
                    }
                }
            }
            return arr;
        }

        public static int FindQuantityOfBiggerElements(int[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);
            int countOfbiggerElement = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i - 1 >= 0 && i + 1 < row && j - 1 >= 0 && j + 1 < column)
                    {
                        if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i, j - 1])
                        {
                            countOfbiggerElement++;
                        }
                    }
                }

            }
            return countOfbiggerElement;
        }

        public static void GameConditions(int quantityR, int quantityC, int opponentChoose, string[,] arr)
        {
            Random rnd = new Random();
            int markedCellsCount = 0;
            int totalMarkedCellsCount = quantityR * quantityC;

            switch (opponentChoose)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Введите номер строки");
                        int r, c;
                        try
                        {
                            r = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Неверно задано значение строки");
                            continue;
                        }
                        Console.WriteLine("Введите номер столбца");
                        try
                        {
                            c = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Неверно задано значение столбца");
                            continue;
                        }

                        string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                        if (arr[r, c] != "+")
                        {
                            Console.WriteLine("Увы! Эта клетка занята!");
                            continue;
                        }
                        arr[r, c] = currentMarker;
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                        int markersCount = 0;
                        if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && arr[r - 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && arr[r + 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r - 1 >= 0 && c + 1 < 5 && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && c + 2 < 5 && arr[r - 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c + 1 < 5 && markersCount != 3 && arr[r, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c + 2 < 5 && arr[r, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c + 1 < 5 && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c + 2 < 5 && arr[r + 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && markersCount != 3 && arr[r + 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && arr[r + 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c + 1 < 5 && arr[r - 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && arr[r, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (markersCount == 3)
                        {
                            Console.WriteLine($"Игрок {currentMarker} победил!");
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine();
                        markedCellsCount++;
                    }
                    while (markedCellsCount <= totalMarkedCellsCount);
                    break;

                case 2:
                    do
                    {
                        string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                        int r = 0, c = 0;
                        if (markedCellsCount % 2 == 0)
                        {
                            Console.WriteLine("Введите номер строки");

                            try
                            {
                                r = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Неверно задано значение строки");
                                continue;
                            }
                            Console.WriteLine("Введите номер столбца");
                            try
                            {
                                c = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Неверно задано значение столбца");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите номер строки");

                            try
                            {
                                r = rnd.Next(0, arr.GetLength(0) - 1);
                            }
                            catch
                            {
                                Console.WriteLine("Неверно задано значение строки");
                                continue;
                            }
                            Console.WriteLine("Введите номер столбца");
                            try
                            {
                                c = rnd.Next(0, arr.GetLength(1) - 1);
                            }
                            catch
                            {
                                Console.WriteLine("Неверно задано значение столбца");
                                continue;
                            }
                        }

                        if (arr[r, c] != "+")
                        {
                            Console.WriteLine("Увы! Эта клетка занята!");
                            continue;
                        }
                        arr[r, c] = currentMarker;
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                        int markersCount = 0;
                        if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && arr[r - 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && arr[r + 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r - 1 >= 0 && c + 1 < 5 && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && c + 2 < 5 && arr[r - 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c + 1 < 5 && markersCount != 3 && arr[r, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c + 2 < 5 && arr[r, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c + 1 < 5 && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c + 2 < 5 && arr[r + 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && markersCount != 3 && arr[r + 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && arr[r + 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c + 1 < 5 && arr[r - 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && arr[r, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (markersCount == 3)
                        {
                            Console.WriteLine($"Игрок {currentMarker} победил!");
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine();
                        markedCellsCount++;
                    }
                    while (markedCellsCount <= totalMarkedCellsCount);
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Введите номер строки");
                        int r, c;
                        try
                        {
                            r = rnd.Next(0, arr.GetLength(0) - 1);
                        }
                        catch
                        {
                            Console.WriteLine("Неверно задано значение строки");
                            continue;
                        }
                        Console.WriteLine("Введите номер столбца");
                        try
                        {
                            c = rnd.Next(0, arr.GetLength(1) - 1);
                        }
                        catch
                        {
                            Console.WriteLine("Неверно задано значение столбца");
                            continue;
                        }

                        string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                        if (arr[r, c] != "+")
                        {
                            Console.WriteLine("Увы! Эта клетка занята!");
                            continue;
                        }
                        arr[r, c] = currentMarker;
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                        int markersCount = 0;
                        if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && arr[r - 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && arr[r + 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r - 1 >= 0 && c + 1 < 5 && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r - 2 >= 0 && c + 2 < 5 && arr[r - 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r + 1 < 5 && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c + 1 < 5 && markersCount != 3 && arr[r, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c + 2 < 5 && arr[r, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c + 1 < 5 && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c + 2 < 5 && arr[r + 2, c + 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && markersCount != 3 && arr[r + 1, c] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && arr[r + 2, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (r + 1 < 5 && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (r + 2 < 5 && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (r - 1 >= 0 && c + 1 < 5 && arr[r - 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && arr[r, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
                        {
                            markersCount = 2;

                            if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)
                            {
                                markersCount = 3;
                            }
                            else if (c + 1 < 5 && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)
                            {
                                markersCount = 3;
                            }
                        }

                        if (markersCount == 3)
                        {
                            Console.WriteLine($"Игрок {currentMarker} победил!");
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine();
                        markedCellsCount++;
                    }
                    while (markedCellsCount <= totalMarkedCellsCount);
                    break;
            }

            Console.WriteLine("Однако, ничья!");
        }

        public static string GetRomanNumber(int number)
        {
            
            StringBuilder romanNumber = new StringBuilder();
            
            for(int i = 0; i < romanAlphabet.Length; i++)
            {
                while (number >= arabicAlternative[i])
                {
                    romanNumber.Append(romanAlphabet[i]);
                    number -= arabicAlternative[i];
                }

            }            
                    
            return romanNumber.ToString();
        }
}
}
