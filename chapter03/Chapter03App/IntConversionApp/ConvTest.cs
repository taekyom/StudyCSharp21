using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0; //0으로 초기화

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값은 {inCastVal}");

            inCastVal += 5; //32767+5 = 32772
            short shCastVal = (short)inCastVal;
            Console.WriteLine($"int값 변환한 short값은 {shCastVal}"); //오버플로우

            float flVal = 3.141592f; //float값이라고 정의 : f or F 입력
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int값은 {inCastVal}");
            double dlVal = inCastVal; //3
            Console.WriteLine($"int값 변환한 double값은 {dlVal}");

            object obj = 20; // Boxing
            int inUnboxingVal = (int)obj; //Unboxing

            string strVal = "200";
            int result = int.Parse(strVal) * 3; //parse : 문자열을 숫자로 형변환
            Console.WriteLine($"200 * 3 = {result}");
        }
    }
}
