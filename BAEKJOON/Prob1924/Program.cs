using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] day = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            int answer;

            if (input[0] == 1)
            {
                answer = input[1] % 7;
            }
            else
            {
                for(int i = 1; i < input[0]; i++)
                {
                    switch (i)
                    {
                        case 2:
                            input[1] += 28;
                            continue;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            input[1] += 30;
                            continue;
                        default:
                            input[1] += 31;
                            continue;
                    }
                }
                answer = input[1] % 7;
            }
            Console.WriteLine(day[answer]);
        }
    }
}
