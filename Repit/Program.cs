using System;

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
        }
    }
}
