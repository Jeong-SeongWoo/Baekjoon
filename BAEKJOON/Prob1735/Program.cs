using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prob1735
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fountain1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] fountain2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int tmp;
            int max = Math.Max(fountain1[1], fountain2[1]);
            int min = max == fountain1[1] ? fountain2[1] : fountain1[1];
            int cnt = 2;

            while (min > 0)
            {
                tmp = max % min;
                max = min;
                min = tmp;
            }
            int multiple = (fountain1[1] * fountain2[1]) / max;
            int answer = (fountain1[0] * (multiple / fountain1[1])) +
                (fountain2[0] * (multiple / fountain2[1]));

            if (multiple == answer)
                Console.WriteLine(1 + " " + 1);

            else
            {
                while (true)
                {
                    if (answer % cnt == 0 && multiple % cnt == 0)
                    {
                        answer /= cnt;
                        multiple /= cnt;
                        cnt = 2;
                    }
                    else
                        cnt++;

                    if (cnt == Math.Max(answer, multiple))
                        break;
                }

                Console.WriteLine(answer + " " + multiple);
            }
        }
    }
}
