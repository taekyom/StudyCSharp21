using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initialize() //virtual : 자식 클래스에서 재정의할 것이라고 선언
            {
                Console.WriteLine("ArmorSuite 초기화!");
            }
        }

        class IronMan : ArmorSuite //ironman은 armorsuite를 상속받음
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("리펄서 레이저 장착!"); 
                Console.WriteLine("Micro-Rocket Launcher 장착!");

            }
        }
        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                //base.Initialize(); //부모가 가진 initialize 실행 후 자식 실행(주석처리하면 부모 실행 안하고 자식 실행)
                Console.WriteLine("ArmorSuite 개량 WarMachine 초기화!"); //base.initialize 실행 후 자식에 재정의 한 것 실행
                Console.WriteLine("Double-Barrel 캐논 장착!");
                Console.WriteLine("Micro-Rocket Launcher 장착!");

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("Iron-Man 생산!");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
    }
    }
}
