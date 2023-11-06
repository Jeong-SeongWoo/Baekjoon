using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1978
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split();
            int decimalcnt = 0;

            for (int i = 0; i < n; i++)
            {
                int cnt = 0;
                if (int.Parse(num[i]) == 1)
                    continue;
                else
                {
                    for(int j = 1; j <= int.Parse(num[i]); j++)
                    {
                        if (int.Parse(num[i]) % j == 0)
                        {
                            cnt++;
                        }
                    }
                }
                if(cnt == 2)
                    decimalcnt++;
            }
            Console.WriteLine(decimalcnt);
        }
    }
}
