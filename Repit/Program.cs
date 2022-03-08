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

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int n = 900;
            Increment(ref n);
            int sum = Sum(900, n);
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
