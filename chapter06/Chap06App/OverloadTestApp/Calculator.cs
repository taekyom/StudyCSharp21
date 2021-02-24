using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.plus(3.14, 5.6)}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.plus(3.14, "5")}");
            int z = Calculator.plus(7, 8, 9);

            int total = 0;
            total = Sum(1, 2, 4, 5, 6);

            Console.WriteLine($"합계는 {total}");
            Console.WriteLine($"10까지의 합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");
        }

        private static int Sum(params int[] args)
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            };
            return result;
        }

        private static double plus(double v1, string v2)
        {
            double p2 = 0;
            double.TryParse(v2, out p2);
            double result = v1 + p2;
            return result;
        }

        private static double plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static float plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
    }
}
