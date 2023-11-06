using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1193
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 1;
            int answer = 1;
            if (n == 1)
            {
                Console.WriteLine("1/1");
            }
            else
            {
                while (true)
                {
                    n = n - cnt;//cnt는 몇번째 라인인지. n은 몇 칸 이동해야하는지.
                    cnt++;
                    if (n <= cnt)
                        break;
                }

                if (cnt % 2 == 0)
                {
                    for (int i = 1; i < n; i++)
                    {
                        cnt = cnt - 1;
                        answer = i + 1;
                    }
                    Console.WriteLine("{0}/{1}", answer, cnt);
                }
                else
                {
                    for (int i = 1; i < n; i++)
                    {
                        cnt = cnt - 1;
                        answer = i + 1;
                    }
                    Console.WriteLine("{0}/{1}", cnt, answer);
                }
            }
        }
    }
}
