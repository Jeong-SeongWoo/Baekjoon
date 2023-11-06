using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2581
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0, min = int.MaxValue;

            for (int i = m; i <= n; i++)
            {
                int cnt = 0;
                for (int j = 1; j <= i;  j++)
                {
                    if(i % j == 0)
                        cnt++;

                    if (cnt > 2)
                        break;
                }
                if (cnt == 2)
                {
                    sum += i;
                    if (i < min)
                        min = i;
                }
            }
            if (sum == 0)
                sb.Append("-1");
            else
            {
                sb.AppendLine("" + sum);
                sb.AppendLine("" + min);
            }
            Console.Write(sb);
        }
    }
}
