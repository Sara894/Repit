using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class Person
    {
        public string name = "Undefined";
        public int age;

        public Person() : this("Undefined")//конструктор доступен вне класса Человек
        {
      
        }

        public Person(string name) : this(name, 18)
        {
           
        }
        public Person(string name, int age)
        {
            Console.WriteLine("Создание объекта Человек с именем и возрастом");
            this.name = name;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Имя {name}, возраст : {age}");

        
    };
}
