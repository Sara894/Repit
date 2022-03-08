using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class Person
    {
        public string name = "Undefined";
        public int age;

        public void Print()
        {
            Console.WriteLine($"Имя {name}, возраст : {age}");
        }
    };
}
