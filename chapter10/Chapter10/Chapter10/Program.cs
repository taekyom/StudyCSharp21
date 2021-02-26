using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{

    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 }; //new int[5];
            /*array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;*/

            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            /*var idx = 0;
            foreach (var item in array) //foreach
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");

            }*/

            Console.WriteLine("오름차순 정렬 후");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순 정렬 후");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"100의 인덱스 : {idx}"); //결과 -1 : 배열 안에 없다는 소리

            Console.WriteLine("배열 삭제");
            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
        }
    }
}
