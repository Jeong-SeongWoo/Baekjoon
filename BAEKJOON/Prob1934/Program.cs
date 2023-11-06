using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1934
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int cnt = 1;

                while (true)
                {
                    if (input[1] * cnt % input[0] == 0)
                    {
                        sb.AppendLine((input[1] * cnt).ToString());
                        break;
                    }
                    else
                        cnt++;
                        continue;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
