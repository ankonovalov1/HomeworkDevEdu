using System;
using System.Collections;
using System.Text;

namespace Homework
{
    public class SingleLinkedList
    {
        Node1 first;
        Node1 last;
        int size = 0;

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

        public bool Contains(int value)
        {
            Node1 currentNode = first;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                    return true;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void AddLast(int value)
        {
            Node1 newNode1 = new Node1(value);
            if (first == null)
            {
                first = newNode1;
            }
            else
            {
                last.Next = newNode1;
            }

            last = newNode1;
            size++;
        }
        public void AddFirst(int value)
        {
            Node1 newNode1 = new Node1(value);
            if (first == null)
            {
                first = newNode1;
                last = newNode1;
            }
            else
            {
                newNode1.Next = first;
            }

            first = newNode1;
            size++;
        }
        public void AddAt(int index, int value)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            Node1 newNode = new Node1(value);
            if (index == 0)
            {
                AddFirst(value);
            }
            if (index == size - 1)
            {
                AddLast(value);
            }
            Node1 currentNode = first;
            Node1 prevNode = first;
            for (int i = 0; i < index; i++)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }

            prevNode.Next = currentNode;
            newNode.Next = currentNode.Next.Next;
            currentNode = newNode;            
            size++;

        }

        public void AddAt(int index, int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                AddAt(index, values[i]);
            }
        }
        public void AddLast(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Node1 newNode1 = new Node1(values[i]);
                if (first == null)
                {
                    first = newNode1;
                }
                else
                {
                    last.Next = newNode1;
                }

                last = newNode1;
                size++;
            }
        }
        public void AddFirst(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                Node1 newNode1 = new Node1(values[i]);
                if (first == null)
                {
                    first = newNode1;
                    last = newNode1;
                }
                else
                {
                    newNode1.Next = first;
                }

                first = newNode1;
                size++;
            }
        }

        public void RemoveFirst(int value)
        {
            Node1 currentNode = first;
            Node1 previousNode = null;
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
        
        public void RemoveAll(int value)
        {
            Node1 currentNode = first;
            Node1 previousNode = null;
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
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException();

            if (index == size - 1)
            {
                RemoveLast();
                return;
            }

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            Node1 currentNode = first;
            Node1 temp = first;
            for (int i = 0; i < index; i++)
            {
                temp = currentNode;
                currentNode = currentNode.Next;
            }
            temp.Next = currentNode.Next;
            size--;
        }
        public void Set(int index, int value)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException();

            Node1 currentNode = first;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Value = value;
        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            int index = 0;
            Node1 currentNode = first;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }
            return array;
        }
        public int GetFirst()
        {
            return first.Value;
        }
        public int GetLast()
        {
            return last.Value;
        }
        public int Get(int index)
        {
            Node1 currentNode = first;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }

        public void Reverse()
        {

            Node1 currentNode = first;


            while (currentNode.Next != null)
            {
                Node1 nextNode = currentNode.Next;
                currentNode.Next = nextNode.Next;
                nextNode.Next = first;
                first = nextNode;
            }

        }

        public int IndexOf(int value)
        {
            Node1 currentNode = first;
            for (int i = 0; i < size; i++)
            {
                if (currentNode.Value.Equals(value))
                    return i;
                currentNode = currentNode.Next;
            }
            return -1;
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
                    last = null;
                }

                size--;
            }
        }


    }
}
