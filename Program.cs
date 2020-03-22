using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание #1
            Console.WriteLine("Task 1...");
            double a = 16.28, b = 12.4, c = 0.0;
            c = Math.Sqrt(a * b);
            Console.WriteLine($"Results: {c}");
            ///////////////////////////////////////////

            //Задание #2
            Console.WriteLine("Task 2...");
            double A = 1.4, B = -5.5, C = 0.6, AC = 0.0, BC = 0.0;
            AC = Math.Abs(A - C);
            BC = Math.Abs(B - C);
            Console.WriteLine($"AC: {AC}");
            Console.WriteLine($"BC: {BC}");
            Console.WriteLine($"AC+BC {AC + BC}");
            ///////////////////////////////////////////
            
            //Задание #3
            Console.WriteLine("Task 3...");
            double x1 = -6.2, y1 = 5.2, x2 = 2.1, y2 = 9.8, res = 0.0;
            res = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine($"Results: {res}");
            ///////////////////////////////////////////

            //Задание #4
            Console.WriteLine("Task 4...");
            int ab = 41, ba = 0;
            ba = ab / 10 + ab % 10 * 10;
            Console.WriteLine($"Results: {ba}");
            ///////////////////////////////////////////

            //Задание #5
            Console.WriteLine("Task 5...");
            int N = 10985, X = 0;
            X = N / 60;
            Console.WriteLine($"Results: {X}");
            ///////////////////////////////////////////

            //Задание #6
            Console.WriteLine("Task 6...");
            int K = 202;
            Console.WriteLine($"Results: {K % 7}");
            ///////////////////////////////////////////
        }
    }
}
