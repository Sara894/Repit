using System;

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
    class Program
    {
       
        static void Main(string[] args)
        {
            Person Gena = new Person();
            string name = Gena.name;
            Console.WriteLine(Gena.name);
            Gena.name = "Геннадий";
            Gena.age = 14;
            Console.WriteLine(Gena.age + Gena.name);
        }
    }
}
