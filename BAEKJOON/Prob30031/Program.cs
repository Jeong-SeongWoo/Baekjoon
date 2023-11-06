using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob30031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (int.Parse(input[0]))
                {
                    case 136:
                        sum += 1000;
                        continue;
                    case 142:
                        sum += 5000;
                        continue;
                    case 148:
                        sum += 10000;
                        continue;
                    default:
                        sum += 50000;
                        continue;
                }
            }
            Console.Write(sum);
        }
    }
}
