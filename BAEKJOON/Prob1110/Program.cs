using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int n = int.Parse(Console.ReadLine());
            int sum, cycle = n;

            while (true)
            {
                sum = cycle / 10 + cycle % 10;
                cycle = cycle % 10 * 10 + sum % 10;
                cnt++;

                if (cycle == n)
                    break;
            }

            Console.WriteLine(cnt);
        }
    }
}
