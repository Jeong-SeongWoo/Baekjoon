using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2438
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cnt; i++)
            {
                for (int j = 0; j < i; j++) 
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
