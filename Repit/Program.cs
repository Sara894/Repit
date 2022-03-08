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

        static void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        static void Main(string[] args)
        {
            int n = 900;
            Increment(ref n);
            int sumResult;
            Sum(900, n, out sumResult);
            Console.WriteLine($"Sum: {sumResult}");
        }
    }
}
