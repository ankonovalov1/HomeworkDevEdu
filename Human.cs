using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Human
    {
        public string name;
        public int age;

        public Human(string _name) 
        {
            name = _name;
        }

        public void SayHi()
        {
            Console.WriteLine("Hello!");
        }
    }
}
