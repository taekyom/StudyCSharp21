using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.plus(3, 4);
            int y = Calculator.plus(5, 6);
            int z = Calculator.plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }

        private static int plus(int p1, int p2)
        {
            //throw new NotImplementedException(); //throw는 점프-예외처리
            Console.WriteLine($"input : {p1}, {p2}");
            int result = p1 + p2;
            Console.WriteLine($"output : {result}");
            return result;
        }
    }
}
