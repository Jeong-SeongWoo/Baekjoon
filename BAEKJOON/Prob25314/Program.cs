using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());
            int N = num / 4;

            for (int i = 0;i < N; i++)
            {
                sb.Append("long ");
            }
            sb.Append("int");
            Console.WriteLine(sb.ToString());
        }
    }
}
