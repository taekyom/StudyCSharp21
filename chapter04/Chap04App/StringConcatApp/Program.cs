using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456;
            Console.WriteLine(123 + p2); //579
            Console.WriteLine("123" + p2); //123456
            Console.WriteLine($"123{p2}"); //위와 같음(c# 6.0 이후 문자열 출력하는 방법), 123456
            Console.WriteLine(123 + "456"); //123456
            Console.WriteLine("123" + "456"); //123456

            //관계연산자
            Console.WriteLine("관계연산자");
            int a = 30, b = 30;
            Console.WriteLine(a < b); //False
            Console.WriteLine(a > b); //False
            Console.WriteLine(a <= b); //True
            Console.WriteLine(a >= b); //True
            Console.WriteLine(a == b); //(= =)True
            Console.WriteLine(a != b); //(! =)False

            //논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a >= 0); //True
            Console.WriteLine(a > b || b > 0); //(|| : or)True
            Console.WriteLine(!(a < b)); //True

            //조건연산자(삼항연산자) : 단항 if문 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십 아님";
            /*if (a == 30)
                result = "삼십";
            else
                result = "삼십 아님";*/
            Console.WriteLine(result);

            //NULL 병합연산자
            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}"); //d가 null이면 0으로 대체해서 출력(빈 화면 출력 방지)


        }
    }
}
