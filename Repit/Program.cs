﻿using System;

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

        static void Sum(int y,params int[] nums)
        {
            int result = 0;
            foreach (var n in nums)
            {
                result += n;
            }
            Console.WriteLine(result + y);
        }

        static void Sum(int[] nums, int y)
        {
            Console.WriteLine(nums[0] + y);
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;//базовый вариант
            return n * Factorial(n - 1);
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }


        static int Fibonachi2(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
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
            Sum(1, 2, 3, 4, 5);
            int[] nums = { 23, 45 };
            Sum(100,nums);
            Sum(nums, 89);
            int nf = Factorial(4);
            Console.WriteLine($"Факториал 4:{nf}");
            int fib4 = Fibonachi(4);
            Console.WriteLine($"Fibonachi {fib4}");
            int fib4_2 = Fibonachi2(4);
            Console.WriteLine($"Fibonachi  {fib4_2}");
        }
    }
}
