using System;

namespace Repit
{
    class Program
    {
        static void Increment(ref int n)
        {
            n++;
            Console.WriteLine($"Increments:{n}");
        }
        static void Main(string[] args)
        {
            int n = 900;
            Increment(ref n);
        }
    }
}
