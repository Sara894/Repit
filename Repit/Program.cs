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

        static int Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        static void Main(string[] args)
        {
            int n = 900;
            Increment(ref n);
            int sum;
            Sum(100, 111,out sum);
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
