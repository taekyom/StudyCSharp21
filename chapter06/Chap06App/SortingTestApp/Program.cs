using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before swap {x}, {y}");

            Program.swap(/*ref*/ x, /*ref*/ y); //x와 y값을 바꿔서 정렬하는 기반, ref : 주소를 복사(call by reference/address)

            Console.WriteLine($"After swap {x}, {y}");

        }

        private static void swap(/*ref*/ int p1, /*ref*/ int p2)
        {
            int temp = p1; //temp = 47
            p1 = p2; //p1 = 5, p2 = 5
            p2 = temp; //p2 = 47
        }
    }
}
