using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "이태경", "010-7280-9231", "부산시 해운대구", true);
            var tuple2 = (Idx : 2, name: "홍길동", Phone: "010-1234-5678", Address: "부산시 수영구", Marriage: false);

            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} / {tuple2.Item4} / {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx} / {tuple2.name} / {tuple2.Phone} / {tuple2.Address} / {tuple2.Marriage}");


        }
    }
}
