using System;

namespace MultiInterfaceApp
{
    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날려!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar DreamCar = new DroneCar();
            DreamCar.Run();
            DreamCar.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnable car = DreamCar;
            car.Run();
            //car.fly(); //error

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = DreamCar;
            plane.Fly();
            //plane.run(); //error

        }
    }
}