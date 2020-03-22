using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class ArrayList
    {

        int[] array;
        int realLength;

        public ArrayList()
        {
            array = new int[10];
            realLength = 0;
        }
        public ArrayList(int[] arr)
        {
            array = arr;
            realLength = arr.Length;
        }
        public int[] IncreaseLength()
        {
            int[] newArray = new int[(array.Length * 3) / 2 + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return array = newArray;
        }

        public int[] DecreaseLength()
        {
            int[] newArray = new int[(array.Length / 2)];
            for (int i = 0; i < array.Length / 2; i++)
            {
                newArray[i] = array[i];
            }
            return array = newArray;
        }
        public void Add(int value) // добавляет элемент в массив в конец, возвращает индекс последнего реального элемента.
        {
            if (realLength >= array.Length)
            {
                IncreaseLength();
            }
            array[realLength] = value;
            realLength++;
        }
        public void Add(int index, int value) // добавляет элемент под индексом и сдвигает массив
        {
            if (realLength >= array.Length)
            {
                IncreaseLength();
            }
            if ((index >= 0) && (index < Size()))
            {
                for (int i = Size(); i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = value;
                realLength++;
            }


        }
        public void RemoveAt(int index) // 
        {
            if ((index >= 0) && (index < Size()))
            {
                for (int i = index; i < Size(); i++)
                {
                    array[i] = array[i + 1];
                }
                realLength--;
            }
            if (realLength < array.Length / 2)
            {
                DecreaseLength();
            }
        }
        public void RemoveFirst(int value) // удаляет входное значение один раз
        {
            RemoveAt(IndexOf(value));
        }
        public void RemoveAll(int value) // удаляет входное значениепо всей длине массива
        {
            int[] arr = Search(value);
            for (int i = 0; i < arr.Length; i++)
            {
                RemoveAt(IndexOf(value));
            }
        }

        public void Set(int index, int value) // принимает индекс и значение - поменять это значение по этому индексу
        {
            if ((index >= 0) && (index < Size()))
            {
                array[index] = value;
            }
        }
        public int? Get(int index) // возвращает значение под входным индексом
        {
            if ((index >= 0) && (index < Size()))
            {
                return array[index];
            }
            return null;
        }
        public int[] GetValues() // возвращает значение всех элементов массива
        {
            return array;
        }
        public int Size() // фактический размер массива
        {
            return realLength;
        }
        public bool Contains(int value) // есть ли принятый элемент в массиве, возращает bool 
        {
            for (int i = 0; i < Size(); i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public int[] AddAll(int[] values) // принимает массив и добавляет его к исходному массиву
        {
            while (realLength >= array.Length || (array.Length - Size()) < values.Length)
            {
                IncreaseLength();
            }

            int index = 0;

            while (index < values.Length)
            {
                array[Size()] = values[index];
                realLength++;
                index++;
            }

            return array;
        }
        public int[] AddAll(int inputIndex, int[] values) // 
        {
            while (realLength >= array.Length || (array.Length - Size()) < values.Length)
            {
                IncreaseLength();
            }
            int indexOfLast = (Size() + values.Length) - 1;
            int index1 = realLength - 1;
            int index2 = realLength - 1;
            int index3 = 0;

            if ((inputIndex >= 0) && (inputIndex < Size()))
            {
                for (int i = indexOfLast; i > index2; i--)
                {
                    array[i] = array[index1];
                    index1--;
                    realLength++;
                }

                while (index3 < values.Length)
                {
                    array[inputIndex] = values[index3];
                    inputIndex++;
                    index3++;
                }
            }
            return array;
        }
        public int IndexOf(int value) // найти индекс входного значения (только первого)
        {
            for (int i = 0; i < Size(); i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int[] Search(int value) // возвращает все индексы входного значения 
        {
            int index = 0, count = 0;
            int[] arrOfIndex;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                arrOfIndex = new int[count];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        arrOfIndex[index] = i;
                        index++;
                    }
                }
                return arrOfIndex;
            }
            arrOfIndex = new int[1] { -1 };
            return arrOfIndex;

        }
    }
}
