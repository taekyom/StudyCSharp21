using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 }; //5개 int 배열
            int[] target = new int[source.Length]; //5개 int 배열 초기화

            CopyArray(source, target); //int형 배열 복사
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string 배열복사");
        }

        float[] source3 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
        float[] target3 = new float[source3.Length];
        CopyArray(source3, target3);
        Console.writeline("float 배열 복사");


        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
