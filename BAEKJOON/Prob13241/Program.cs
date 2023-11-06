using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob13241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long max = Math.Max(input[0], input[1]);
            long min = Math.Min(input[0], input[1]);
            long answer , tmp;

            if (max % min == 0)
                answer = max;
            else
            {
                while (min > 0)
                {
                    tmp = max % min;
                    max = min;
                    min = tmp;
                }
                answer = (input[0] * input[1]) / max;
            }

            Console.WriteLine(answer);
        }
    }
}
