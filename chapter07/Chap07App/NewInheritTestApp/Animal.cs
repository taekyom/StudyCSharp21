using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Animal //동물 클래스
    {
        public string Name { get; set; } //프로퍼티(속성)
        public int Age { get; set; } //set이 없으면 상속된 값을 자식클래스에서 사용 불가
        public void Breath()
        {
            Console.WriteLine($"{this.Name}이/가 숨을 쉽니다.");
        }
    }
}
