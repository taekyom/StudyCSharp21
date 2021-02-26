using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal //포유류 클래스
    {
        public string Name { get; set; }
        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을/를 키우다");
        }
    }

    class Dog : Mammal //dog는 mammal을 상속받음
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!");
        }
    }
    class Cat : Mammal //cat은 mammal을 상속받음
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 애옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog ppopi = null; //new Dog();
            /*ppopi.Name = "뽀삐";
            ppopi.Nurse();
            ppopi.Bark();*/

            /*Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Meow();*/

            if (ppopi is Mammal) //뽀삐는 포유류인가?
            {
                //값형식은 long = int값;
                Mammal mammal1 = ppopi as Mammal; //as 부모클래스 : 생략가능(좀 더 정확하게 적기 위해 사용, 어차피 부모는 자식에 들어갈 수 없으므로)
                //참조형식은 as를 써서 형변환(ppopi는 부모클래스로 형변환됐으므로 자식 속성 사용 불가, 부모 속성만 사용 가능)
                mammal1.Nurse();
                /*mammal1.Bark();*/ //ppopi는 부모클래스로 형변환됐으므로 자식 속성 사용 불가, 부모 속성만 사용 가능

            }

            if (mammal is Dog)
            {
                ppopi = mammal as Dog;
                ppopi.Nurse();
                ppopi.Bark();
            }

        }
    }
}
