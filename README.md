## StudyCSharp
C# 학습 리포지토리

--------------------------
## C#
#### 📏 C#이란? <br/>
Microsoft에서 .NET Framework에서 사용하도록 개발한 객체지향 프로그래밍 언어<br/>
1983년에 등장한 C++와 1995년에 등장한 Java에서 강한 영향을 받아 비슷한 문법을 가짐<br/>
개발 툴은 Visual Studio(console로 컴파일도 가능하지만 비추)<br/>
확장자는 .cs <br/>
<br/>

##### *객체지향 프로그래밍이란?* <br/>
OOP(Object-Oriented Programming)<br/>
컴퓨터 프로그램을 명령어의 목록으로 보는 시각에서 벗어나 여러 개의 독립된 단위인 "객체"들의 모임으로 파악하고자 하는 것<br/>
각각의 객체는 메시지를 주고받고, 데이터를 처리가 가능<br/>
객체 지향 프로그래밍은 프로그램을 유연하고 변경이 용이하게 만들기 때문에 대규모 소프트웨어 개발에 주로 사용 <br/>
프로그래밍을 더 배우기 쉽게 하고 소프트웨어 개발과 보수를 간편하게 하며, 보다 직관적인 코드 분석을 가능하게 하는 것이 장점 <br/>
<br/>

#### 📏 C#의 이용 <br/>
- Console Application
- Windows Application
- Web Application(C#을 Web에 이용한 것이 asp.net)

#### 📏 C# 기본구조 <br/>
C#으로 'Hello, World!' 출력하기
```
using System;
namespace //사용하고자 하는 네임스페이스 정의
{
    class //클래스 정의, Main 클래스의 이름을 파일 이름과 같게 지정할 것을 추천
    {
        static void Main(string[] args)
        {
            //출력할 코드 작성
        }
     }
}
```
```
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
     }
}
```

