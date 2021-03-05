 using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); //sleep : 시스템을 잠시 멈추는 것, 1000=1초(1ms이므로)/ 1/100초동안 멈춤
            }
        }
        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(10); //sleep : 시스템을 잠시 멈추는 것, 1000=1초(1ms이므로)/ 1/100초동안 멈춤
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomething));
            Thread thread1 = new Thread(SomethingHappened);

            try
            {
                Console.WriteLine("Thread 시작!");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main Thread : {i}");
                    Thread.Sleep(10); 

                    if (i == 0)
                        thread.Abort(); //abort = pause
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine($"Process End");
            }
        }
    }
}
