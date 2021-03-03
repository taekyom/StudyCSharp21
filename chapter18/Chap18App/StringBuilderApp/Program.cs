using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            //sb[6] = 'N'; //권장하지 않음
            sb.Append("My name is HUGO\n");
            sb.Append("I'm 47years old\n");
            sb.Insert(6, "NEW ");
            sb.Replace("Book", "시계");
            Console.WriteLine(sb);
        }
    }
}
