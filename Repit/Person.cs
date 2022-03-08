using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class Person
    {
        public string name = "Undefined";
        public int age;

        public Person()//конструктор доступен вне класса Человек
        {
            Console.WriteLine("Создание объекта Person");
            name = "Lana Terner";
            age = 30;
        }
        public void Print()
        {
            Console.WriteLine($"Имя {name}, возраст : {age}");
        }
    };
}
