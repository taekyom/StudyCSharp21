using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자
            char ch1 = 't', ch2 = '\t', ch3 = '\n', ch4 = '0'; //''안에는 문자 1개만 입력가능, \는 특수문자(이스케이프문자), \t는 tab(=4space), \n은 줄바꿈
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\'; //역슬래시 출력방법
            Console.WriteLine($"{ch5}");
            
            //문자열
            string str1 = "\tHello, \nWorld!";
            //Console.WriteLine(str1);
            Console.WriteLine($"{str1}");

            //Boolean(bool)
            Boolean isCorrect = false;
            if (isCorrect) 
            {
                Console.WriteLine("참입니다.");
            }
            else 
            {
                Console.WriteLine("거짓입니다.");
            }
            Console.WriteLine(isCorrect);
        }
    }
}
