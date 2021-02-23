using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("이태경", "010-7280-9231");
           if(PrintProfile(null, "010-1111-2222") == -1) ;
            {
                Console.WriteLine("프로필 출력 시 오류가 발생했습니다.");
            }
        }
        public static int PrintProfile(string name, string phone) 
        {
            if (string.IsNullOrEmpty(name)) 
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1; //밑에거 실행 안하고 끝내겠다.
            }

            //프로필 출력
            Console.WriteLine($"이름 : {name}, 휴대폰번호 : {phone}");
            return 0;
        }
    }
}
