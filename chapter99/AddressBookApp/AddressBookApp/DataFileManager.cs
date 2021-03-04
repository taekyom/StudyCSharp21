using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {   //텍스트 파일에서 저장된 주소록을 불러온다(파일 로드) 
        const string dataFileName = "address.dat";
        //C:\Sources\GitRepository\StudyCSharp21\chapter99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; //데이터 파일 위치와 파일명

            var sr = new StreamReader(new FileStream(filepath, FileMode.Open, FileAccess.Read)); //open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                //temp data를 잘라서 listResult에 할당
                var splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list)
        {
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; //데이터 파일 위치와 파일명

            //주소록을 다시 파일에 쓴다
            var sw = new StreamWriter(new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count >= 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name} | {item.Phone} | {item.Address}");
                }
            }

            sw.Close();
        }

    }
}
