using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2446
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                    sb.Append(' ');
                for(int k = 0; k <= 2 * n - 2 * i ; k++)
                    sb.Append('*');
                sb.Append('\n');
            }

            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                    sb.Append(' ');
                for (int k = 0; k < 2 * i + 1; k++)
                    sb.Append('*');
                sb.Append('\n');
            }
            Console.Write(sb);
        }
    }
}
