using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); //메시지를 받아서 처리하는 대리자 선언(void는 return값이 없음)

    class CustomNotifier
    {   //이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened; //이벤트핸들러라는 이름을 가진 somethinghappened라는 인스턴스 이벤트
        public void DoSomething(int number) //대리자와 같은 형태가 되어야 함
        {
            int temp = number % 10; //13 % 10 = 3
            if (temp != 0 && temp % 3 == 0) //3, 6, 9로 떨어지는 값
            {
                SomethingHappened($"{number} : 짝!"); //이벤트를 사용!(로직은 없음)
            }
            else
            {
                SomethingHappened($"{number}");
            }
        }

    }
    class Program
    {   //이벤트가 발생했을 때 실행되는 메서드(이벤트 핸들러)
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); // 내가 만든 로직이 있는 메소드와 이벤트를 연결해줌

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
