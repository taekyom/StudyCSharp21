using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    class AddressManager
    {
        public List<AddressInfo> listaddress = new List<AddressInfo>(); //주소록을 담을 컬렉션

        public void Printmenu()
        {
            //메뉴 출력
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("1. 주소입력");
            Console.WriteLine("2. 주소검색");
            Console.WriteLine("3. 주소수정");
            Console.WriteLine("4. 주소삭제");
            Console.WriteLine("5. 주소 전체출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        public int SelectMenu()
        {
            //메뉴 번호 입력
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine(); //readline은 무조건 string
            /*int menuNum = 0;*/
            int.TryParse(input, out int result);
            if (!(result > 0 && result < 7)) //1~6 이외의 숫자
            {
                result = 0;
            }
            return result;
        }
        public void InputAddress()
        {
            Console.WriteLine("주소 입력");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("연락처 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("빈 값은 입력할 수 없습니다.");
            }
            else
            {
                listaddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
            }
        }
        public void SearchAddress()
        {
            Console.WriteLine("주소 검색");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; // 검색했을 때 찾는 이름이 있는가?
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true; //찾음
                    Console.WriteLine();
                    Console.WriteLine($"[{idx}]▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"연락처 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    break; //foreach를 빠져나가는 break
                }
                idx++;
            }

            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면 멈춤
        }
        public void UpdateAddress()
        {
            Console.WriteLine("주소 수정");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true; //찾음
                    Console.WriteLine();
                    Console.WriteLine($"[{idx}]▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"연락처 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.Write("이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhnoe = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhnoe))
                    {
                        Console.WriteLine("빈 값은 입력할 수 없습니다.");
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhnoe;
                        item.Address = uAddress;
                    }


                    break; //foreach를 빠져나가는 break
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면 멈춤
        }
        public void DeleteAddress()
        {
            Console.WriteLine("주소 삭제");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true; //찾음
                    Console.WriteLine($"[{idx}]▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"연락처 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.Write("삭제하시겠습니까? [y/n]");
                    string answer = Console.ReadLine(); //y/n
                    if (answer.ToUpper() == "Y")
                    {
                        listaddress.RemoveAt(idx);
                        Console.WriteLine("삭제했습니다.");
                    }

                    break; //foreach를 빠져나가는 break
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면 멈춤
        }
        public void PrintAllAddress()
        {
            Console.WriteLine("주소 전체 출력");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            int idx = 0;

            if (listaddress.Count == 0)
            {
                Console.WriteLine("주소록이 없습니다.");
            }
            else
            {
                foreach (var item in listaddress)
                {
                    Console.WriteLine($"[{idx}]▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"연락처 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    idx++;
                }
            }

            Console.ReadLine(); //화면 멈춤
        }
    }
}
