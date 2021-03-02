using System;

namespace TryCatchApp
{
    class Program
    {
        //예외
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                
            }
            Console.WriteLine("나머지 일처리 계속");

            int x = 108, y = 0;
            int result = 0;
                       

            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속!");

            string strVal = null;
            
            try
            {
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. 값을 입력하세요. {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화하세요. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"기타 예외발생. {ex.Message}");
            }

            Console.WriteLine("일처리 또 있음");
        }
    }
}
