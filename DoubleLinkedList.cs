using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class DoubleLinkedList
    {
        Node first;
        Node last;
        int size;

        public DoubleLinkedList()
        {
            
        }
        public DoubleLinkedList(int[] array)
        {
            AddFirst(array);
        }

        public bool Contains(int value)
        {
            Node currentNode = first;
            for (int i = 0; i < size; i++)
            {
                if (currentNode.Value.Equals(value))
                    return true;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public int IndexOf(int value)
        {
            Node currentNode = first;
            for (int i = 0; i < size; i++)
            {
                if (currentNode.Value.Equals(value))
                    return i;

                currentNode = currentNode.Next;
            }

            return -1;
        }

        public void Reverse()
        {
            Node currentNode = first;
            last = first;
            while (currentNode != null)
            {
                Node temp = currentNode.Next;
                currentNode.Next = currentNode.Previous;
                currentNode.Previous = temp;

                if (currentNode.Previous == null)
                {
                    first = currentNode;
                }
                currentNode = currentNode.Previous;
            }
        }

        public int GetFirst()
        {
            return first.Value;
        }

        public int Get(int index)
        {
            Node currentNode = first;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }
        public int GetLast()
        {
            return last.Value;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                last.Next = newNode;
                newNode.Previous = last;
            }

            last = newNode;
            size++;
        }

        public void AddAt(int index, int value)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }

            Node newNode = new Node(value);

            if (index == 0)
            {
                AddFirst(value);
            }
            if (index == size - 1)
            {
                AddLast(value);
            }
            Node currentNode = first;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            Node prevNode = currentNode.Previous;

            prevNode.Next = newNode;
            currentNode.Previous = newNode;
            newNode.Previous = prevNode;
            newNode.Next = currentNode;
            size++;
        }

        public void Clear()
        {
            size = 0;
            first = null;
            last = null;
        }

        public int GetSize()
        {
            return size;
        }

        public bool isEmpty()
        {
            if (size == 0) return true;
            else return false;
        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            int index = 0;
            Node currentNode = first;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }
            return array;
        }

        public void AddFirst(int value)
        {
            Node newNode1 = new Node(value);
            if (first == null)
            {
                first = newNode1;
                last = newNode1;
            }
            else
            {
                newNode1.Next = first;
                first.Previous = newNode1;
            }

            first = newNode1;
            size++;
        }

        public void Set(int index, int value)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException();

            Node currentNode = first;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Value = value;
        }

        public void RemoveFirst(int value)
        {
            Node currentNode = first;
            Node previousNode = null;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    if (previousNode != null)
                    {
                        previousNode.Next = currentNode.Next;

                        if (currentNode.Next == null)
                        {
                            last = previousNode;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        first = first.Next;

                        if (first == null)
                        {
                            last = null;
                        }
                    }
                    size--;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }


        public void RemoveFirst()
        {
            if (size != 0)
            {
                first = first.Next;

                size--;

                if (size == 0)
                {
                    last = null;
                }
                else
                {
                    first.Previous = null;
                }
            }
        }
        public void RemoveLast()
        {
            if (size != 0)
            {
                if (size == 1)
                {
                    first = null;
                    last = null;
                }
                else
                {
                    last.Previous.Next = null;
                    last = last.Previous;
                }

                size--;
            }
        }

        public void RemoveAll(int value)
        {
            Node currentNode = first;            
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    if (currentNode.Previous != null)
                    {
                        currentNode.Previous.Next = currentNode.Next;
                        
                        if (currentNode.Next != null)
                        {
                            currentNode.Next.Previous = currentNode.Previous;
                        }
                        else
                        {
                            last = currentNode.Previous;
                        }
                    }
                    else
                    {
                        first = currentNode.Next;

                        if (first == null)
                        {
                            last = null;
                        }
                    }
                    size--;
                }
                currentNode.Previous = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void AddFirst(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                Node newNode1 = new Node(values[i]);
                if (first == null)
                {
                    first = newNode1;
                    last = newNode1;
                }
                else
                {
                    newNode1.Next = first;
                    first = newNode1;
                }

                size++;
            }
        }
        public void AddLast(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Node newNode1 = new Node(values[i]);
                if (first == null)
                {
                    first = newNode1;
                }
                else
                {
                    last.Next = newNode1;
                    newNode1.Previous = last;
                }

                last = newNode1;
                size++;
            }
        }
    }
}
