using System;

namespace Chap18App
{
    class String
    {
        string temp2 = "Global Variable String"; //global : var는 사용불가 
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작!");

            //기본 선언
            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1}."); //초기화하지 않은 변수 사용 불가능
            string message2 = string.Empty; //"";
            Console.WriteLine($"빈 값 문자열 : {message1}.");

            //파일이나 프로그램 상에서 폴더, 파일 경로를 나타내는 방법
            string oldPath = "C:\\Program Files\\Bandizip"; //옛날방식이므로 역슬래시는 특수문자로 간주, 역슬래시 한번 더 입력해야함
            string newPath = @"C:\Program Files\Bandizip";
            
            //string
            string Greeting = "Hello World!";

            //Local : 지역변수에만 사용 가능
            var temp1 = "Local Variable String";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "Hello ";
            string s2 = "World";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            //줄 바꿈
            string row = "Row1\r\nRow2\r\nRow3"; // \r\n : 표준
            Console.WriteLine(row);
            Console.WriteLine();

            string row2 = "Row11\nRow22\nRow33"; // \r\n = \r = \n
            Console.WriteLine(row2);
            Console.WriteLine();

            Console.WriteLine("Row111" + Environment.NewLine + "Row222" + Environment.NewLine + "Row333");

            string oldline = "Test" +
                "Test2" +
                "Test3";
            string multiline = @"New Test
These are multiline
end.";
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);

            Console.WriteLine("\U0001F47D"); //👽

            var book = (lastname: "박", firstname: "상현", title: "이것이 C#이다",
                        company: "한빛미디어", releaseDate: "2018-07-01", price: 30000, page : 812);
            Console.WriteLine($"{book.lastname}{book.firstname}저자의 {book.title}({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간, 페이지수 {book.page}, 금액 : {book.price:#,###}원");         

            Console.WriteLine("문자열 조작 함수 사용");
            string s5 = " Visual C# Express "; //총 19자리
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim()); //스페이스(여백) 삭제
            var s6 = s5.Trim(); //총 17자리 : 앞뒤 여백 삭제했으므로

            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7, 2));

            Console.WriteLine(s6.Replace("C#", "Basic"));
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic"));

            Console.WriteLine(s6.IndexOf("C")); //7
            Console.WriteLine(s6.Length); //17
            Console.WriteLine(s6.ToLower()); //전체 소문자로 변경
            Console.WriteLine(s6.ToUpper()); //전체 대문자로 변경

            //null 문자열(빈 문자열)
            Console.WriteLine("null/빈문자열 처리");
            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr); //hello 출력
            Console.WriteLine(nullstr == emptystr);

            try
            {
                Console.WriteLine(nullstr == emptystr); //예외발생
                Console.WriteLine(emptystr.Length); //0
                Console.WriteLine(nullstr.Length); //예외발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            
        }
    }
}
