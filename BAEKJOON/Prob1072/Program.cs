using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] game = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long winrate = game[1] * 100 / game[0];
            int cnt = 1;

            if (game[0] == game[1])
            {
                Console.WriteLine(-1);
            }
            else
            {
                while (true)
                {
                    game[0]++;
                    game[1]++;

                    if (game[1] * 100 / game[0] > winrate)
                    {
                        Console.WriteLine(cnt);
                        break;
                    }
                    cnt++;
                }
            }
        }
    }
}
