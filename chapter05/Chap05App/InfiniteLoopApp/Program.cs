using System;

namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte idx = 0;
            //for ( ; ; ) //무한루프
            while (true) //위와 같음
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
