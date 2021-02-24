using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        internal int Temp = 5; //물온도
        //public 안 쓰면 초기에는 private으로 설정됨, internal은 거의 안 씀, public/private/protected를 가장 많이 씀

        public void SetTemp(int Temp)
        {
            if(Temp < 30 || Temp > 50)
            {
                Console.WriteLine("물의 온도가 일정 온도를 벗어났습니다. 59℃로 맞춥니다.");
                this.Temp = 59;
                return;
            }
            else
            {
                this.Temp = Temp;
            }

        }

        public int GetTemp()
        {
            return this.Temp;
        }

        public void TurnOnTheBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnOffTheBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler(); //kitturami라는 인스턴스 생성
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp}℃입니다.");
            kitturami.SetTemp(40);
            kitturami.TurnOnTheBoiler();
            kitturami.SetTemp(59);


            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffTheBoiler();
            }
        }
    }
}
