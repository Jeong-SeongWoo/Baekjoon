using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int room = 1;
            int answer;
            int n = int.Parse(Console.ReadLine());

            while(true)
            {
                room = room + (cnt * 6);
                answer = cnt + 1;
                if (room >= n)
                    break;
                cnt++;
            }
            Console.WriteLine(answer);
        }
    }
}
