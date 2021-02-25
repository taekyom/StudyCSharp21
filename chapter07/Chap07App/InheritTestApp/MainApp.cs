using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name} Parent() 생성자");
        }

        ~Parent()
        {
            Console.WriteLine($"{this.Name} Parent() 소멸자");
        }

        public void ParentMethod()
        {
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    class Child : Parent
    {
        public string color; //색상, 클래스의 속성들을 public으로 만드는 것은 제일 위험(외부에서 접근 가능하므로)

        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.child() 생성자");
        }

        /*~Child()
        {
            Console.WriteLine($"{this.Name} child() 소멸자");
        }*/
        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); //부모 클래스의 메서드를 실행

            Child c = new Child("자식");
            c.color = "황색";
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식 클래스의 메서드를 실행
        }
    }
}
