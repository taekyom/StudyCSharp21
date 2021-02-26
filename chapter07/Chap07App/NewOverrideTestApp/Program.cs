using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal //포유류 클래스
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이/가 숨을 쉰다");
        }

        public virtual void Move()
        {
            Console.WriteLine($"(부모작업) {this.Name}이/가 이동한다");
        }
    }

    class Dog : Mammal
    {
        /*public void Move()
        {
            Console.WriteLine($"{this.Name}이/가 네 발로 이동한다");
        }*/
        public override void Move()
        {
            base.Move(); //virtual쓸 때 : 부모가 가지고 있는 move 동작시키고 자식의 move가 추가 동작
            Console.WriteLine($"{this.Name}이/가 네발로 이동한다");
        }
    }

    class Human : Mammal
    {
        public void Move() //부모의 메소드를 숨김
        {
            Console.WriteLine($"{this.Name}이/가 두발로 이동한다");
        }
    }

    class Whale : Mammal
    {
        public override void Move() //부모의 메소드를 재정의
        {
            Console.WriteLine($"{this.Name}이/가 지느러미로 헤엄친다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog ppoppi = new Dog();
            ppoppi.Name = "뽀삐";
            ppoppi.Move();

            Human mansik = new Human();
            mansik.Name = "만식";
            mansik.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();
        }
    }
}
