using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34}; //new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("크기 변경");
            Array.Resize(ref array, 6);

            Console.WriteLine("81 index 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >= idx;  i--)
            {
                array[i] = array[i - 1];
            }
            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}번째 값 : {array[i]}\t\n");
            }

        }
    }
}
