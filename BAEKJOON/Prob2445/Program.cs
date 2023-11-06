using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2445
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            char[] answer = new char[2 * n];
            answer = Enumerable.Repeat(' ',2 * n).ToArray();

            for(int i=0; i < n; i++)
            {
                answer[i] = '*';
                answer[(2 * n - 1) - i] = '*';

                for(int j=0; j < 2 * n; j++)
                {
                    sb.Append(answer[j]);
                }
                sb.Append('\n');
            }

            for(int i = n - 1; i >= 1; i--)
            {
                answer[0 + i] = ' ';
                answer[(2 * n - 1) - i] = ' ';

                for (int j = 0; j < 2 * n; j++)
                {
                    sb.Append(answer[j]);
                }
                sb.Append('\n');
            }
            Console.Write(sb);
        }
    }
}
