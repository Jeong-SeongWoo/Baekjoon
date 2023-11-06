using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] a = new int[n, m];
            int[,] answer = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] num = Console.ReadLine().Split();
                for(int j = 0; j < m; j++)
                {
                    a[i,j] = int.Parse(num[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                string[] num = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    answer[i,j] = a[i,j] + int.Parse(num[j]);
                    sb.Append(answer[i, j] + " ");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
