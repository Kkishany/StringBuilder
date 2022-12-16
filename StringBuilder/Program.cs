using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.Day10
{
    class StringBuilderEx
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("hello world");
            sb.AppendLine("hii ");
            sb.AppendLine("Welcome to ");
            sb.AppendLine("Infinite");
            Console.WriteLine($"Capacity : {sb.Capacity}");
            Console.WriteLine($"Length : {sb.Length}");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();



        }
    }
}
