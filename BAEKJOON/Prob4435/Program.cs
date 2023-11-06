using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int[] good = { 1, 2, 3, 3, 4, 10 };
            int[] evil = { 1, 2, 2, 2, 3, 5, 10 };


            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int totscore_g = 0, totscore_e = 0;
                int[] army_g = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] army_e = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int j = 0; j < good.Length; j++)
                    totscore_g += good[j] * army_g[j];
                
                for (int j = 0; j < evil.Length; j++)
                    totscore_e += evil[j] * army_e[j];

                if (totscore_e > totscore_g)
                    sb.AppendLine($"Battle {i + 1}: Evil eradicates all trace of Good");
                else if (totscore_e == totscore_g)
                    sb.AppendLine($"Battle {i + 1}: No victor on this battle field");
                else
                    sb.AppendLine($"Battle {i + 1}: Good triumphs over Evil");
            }
            Console.WriteLine(sb);
        }
    }
}
