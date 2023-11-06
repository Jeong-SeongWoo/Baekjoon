using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prob2458
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int min = int.MaxValue;
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if( i > 0)
                    min = Math.Min(min, input[i] - input[i - 1]);
            }

            for( int i = 1;i < n; i++)
            {
                if ((input[i] - input[i - 1]) % min != 0)
                {
                    i = 1;
                    min--;
                    answer = 0;
                }
                else
                    answer += (input[i] - input[i - 1]) / min;
            }
            Console.WriteLine(answer);
        }
    }
}
