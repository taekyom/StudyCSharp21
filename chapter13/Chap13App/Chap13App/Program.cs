using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자, 대신 호출한다. 호출할 메서드와 파라미터 타입 , 개수가 일치해야만 한다.

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {Callback(3, 4)}");

            Callback = new MyDelegate(calc.Minus);

        }
    }
}
