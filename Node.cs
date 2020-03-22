using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Node
    {
        int value;
        Node next;
        Node previous;
        public Node(int val)
        {
            value = val;
        }

        public Node Next { get; set; }
          

        public Node Previous { get; set; }


        public int Value 
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        

    }
}
