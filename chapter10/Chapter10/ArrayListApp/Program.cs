using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34});
            /*위에 한줄로 표현 가능 =
            array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/

            var loc = array.IndexOf(81); //index 81의 위치
            array.Insert(loc, 50); //81위치에 50을 넣고 한칸 밀어라

            Console.WriteLine("81 위치에 50 추가");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);
            array.RemoveAt(4); //4번째 위치 값 삭제 = 90 삭제
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort(); //오름차순 정렬, 내림차순 : reverse();
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
