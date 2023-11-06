using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2443
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for(int j = 0; j < n-i; j++)
                    sb.Append(" ");
                for(int k = 0; k < 2 * i - 1; k++)
                    sb.Append("*");
                sb.Append("\n");
            }
            Console.Write(sb);
        }
    }
}
