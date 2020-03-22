using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Node1
    {
        int value;
        Node1 next;
        
        public Node1(int val)
        {
            value = val;
        }        

        public Node1 Next { get; set; }        

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
