﻿using System;

namespace Repit
{
   
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
            Person Lena = new Person ("Lena");
            Lena.Print();
            Person John = new Person();
            John.Print();
            Person tom = new Person {name = "Tom",age = 19 };//inicializator
            tom.Print();
            //инициализатор только для пабик полей
            //инициализатор выполняется после конструктора
            //поэтому если в конструторе по умолчанию
            //есть значения для полей
            //то онизаменяются значениями из инициализатора
        }
    }
}
