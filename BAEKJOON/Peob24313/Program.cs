using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob24313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int c = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int answer = 1;

            for (int i = n; i <= 100; i++)
            {
                if (input[0] * i + input[1] > c * i)
                    answer = 0;
            }
            Console.WriteLine(answer);
        }
    }
}
