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
        //модификатор in значит что
        //параметр передаем по ссылке
        //при этом в теле метода он неизменяем
        static void GetRectangleData(in int width,in int height,
            out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height;
            rectPerimetr = (width + height) * 2;
        }
        static void Main(string[] args)
        {
            int n = 900;
            Increment(ref n);
            int sumResult;
            Sum(900, n, out sumResult);
            Console.WriteLine($"Sum: {sumResult}");
            GetRectangleData(20, 30, out var area, out var perimetr);
            Console.WriteLine($"area: {area}");
            Console.WriteLine($"perimetr:{perimetr}");
        }
    }
}
