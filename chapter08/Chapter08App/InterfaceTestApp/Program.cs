using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
   /* class Ridable //탈 것
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈 것");
        }
    }*/

    interface ICar 
    {
        void Run();
        void Ride();
       
    }

    interface IPlane 
    {
        void Fly();
        void Ride();
        
    }

    class DroneCar : IPlane, ICar //다중 상속 허용하지 않음
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamcar = new DroneCar();
            dreamcar.Ride();
        }
    }
}
