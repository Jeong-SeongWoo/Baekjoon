using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2960
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] num = new int[n - 1];
            int[] erase = new int[n - 1];
            int cnt = 0;

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = i + 2;
            }

            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] != 1)
                {
                    erase[cnt] = num[i];
                    cnt++;
                    for(int j = i + 1; j < num.Length; j++)
                    {
                        if (num[j] % num[i] == 0)
                        {
                            erase[cnt] = num[j];
                            cnt++;
                            num[j] = 1;
                        }
                    }
                    num[i] = 1;
                    if (cnt >= k)
                        break;
                }
            }
            Console.WriteLine(erase[k - 1]);
        }
    }
}
