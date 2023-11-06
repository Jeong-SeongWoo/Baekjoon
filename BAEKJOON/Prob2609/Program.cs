using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int max = a >= b ? a : b;
            int min = a >= b ? b : a;
            int multicnt = 1;
           
            for (int i = min; i >= 0; i--)
            {
                if (max % i == 0 && min % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            while (true)
            {
                if ((multicnt * max) % min == 0)
                {
                    Console.WriteLine(multicnt * max);
                    break;
                }
                else
                    multicnt++;
            }
        }
    }
}
