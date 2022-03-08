using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class Company 
    {
        public string title = "UndefinedCompany";
        public Company(string title)
        {
            this.title = title;
        }

        public Company()
        {

        }
    };
    class Person
    {
        public string name = "Undefined";
        public int age;
        public Company company;

        public Person() : this("Undefined")//конструктор доступен вне класса Человек
        {
      
        }

        public Person(string name) : this(name, 18,"Microsoft")
        {
           
        }
        public Person(string name, int age,string title)
        {
            Console.WriteLine("Создание объекта Человек с именем и возрастом");
            this.name = name;
            this.age = age;
            this.company = new Company();
        }

        public void Deconstruct(out string name, out int age)
        {
            name = this.name;
            age = this.age;
        }
        public void Print() => Console.WriteLine($"Имя {name}, возраст : {age}");

        
    };
}
