﻿using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    listaddress = new List<AddressInfo>()
                };

                DataFileManager fileManager = new DataFileManager();
                manager.listaddress = fileManager.ReadData();

                while (true) //무한반복
                {
                    Console.Clear();
                    manager.Printmenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        /*case 0: //메뉴선택 실패, 메뉴로 돌아감
                            break;*/
                        case 1: //주소입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;

                        case 2: //주소 검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;

                        case 3: //주소 수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;

                        case 4: //주소 삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;

                        case 5: //주소 전체출력
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;

                        case 6: //프로그램 종료
                            fileManager.WriteData(manager.listaddress);
                            Environment.Exit(0);
                            break;
                        default: //0은 여기서 처리, 아무 로직 없음
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }
    }
}
