using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class Testclass
    {
        public static int number;
        public float fnum;

        public static float ProSomething()
        {
            Console.WriteLine($"{number}, 뭔가를 한다!");
            return 1.0f; //float을 쓰면 항상 return ~f; 여야 함
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Testclass aCls = new Testclass();
            Testclass.number = 10;
            aCls.fnum = 3.25f;

            Testclass bCls = new Testclass();
            bCls.fnum = 4.87f;

            Testclass.ProSomething();
        }
    }
}
