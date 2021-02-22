using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");

            Console.WriteLine($"후치 증가 값은 {result++}"); //19가 출력, 다음 출력될 값에 +1하겠다는 말
            //Console.WriteLine($"현재 숫자는 {result}"); result += 1;
            Console.WriteLine($"전치 증가 값은 {++result}");
            //result += 1; console.wirteline($"현재 숫자는{result}");
            Console.WriteLine($"전치 감소 값은 {--result}");
            Console.WriteLine($"후치 감소 값은 {result--}");


        }
    }
}
