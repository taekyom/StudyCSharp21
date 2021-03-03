using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 9, 6, 5, 3, 7, 8, 1, 10 }; // 사이즈 10짜리 배열
            //LINQ 안쓰는 방식
            /*List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();*/

            //LINQ 쓰는 방식
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;
            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하동훈", Height = 171 },
                new Profile() { Name = "이정재", Height = 187 }
            };

            List<Product> products = new List<Product>
            {
                new Product() {Title = "비트", Star = "정우성"},
                new Product() {Title = "무한도전", Star = "하동훈"},
                new Product() {Title = "CF 다수", Star = "김태희"},
                new Product() {Title = "모래시계", Star = "고현정"},
                new Product() {Title = "런닝맨", Star = "하동훈"},
                new Product() {Title = "관상", Star = "이정재"}
            };

            //객체
            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending //descending     
                              select new 
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  IcnHeight = item.Height * 0.393 // 람다식
                              };
            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.IcnHeight}inch");
            }

            //스트링(문자열)
            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height ascending //descending     
                               select item.Name; //select item.Height;
            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            //group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g //g는 grouping된 값
                               select new { 
                                   GropuKey = g.Key,Items = g
                               };
            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만으로 grouping : {group.GropuKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"    {item.Name}, {item.Height}cm");
                }
            }

            //inner join
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("내부조인 결과");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}cm");
            }

            //outer join
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음"})
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("외부조인 결과");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}cm");
            }
        }
    }
}
