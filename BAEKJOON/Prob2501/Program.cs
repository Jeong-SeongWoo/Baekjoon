using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num = int.Parse(input[0]);
            int prob = int.Parse(input[1]);
            int cnt = 0 ,answer = 0;

            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    cnt++;

                if (cnt == prob)
                {
                    answer = i;
                    break;
                }

                else if (i == num && cnt < prob)
                    answer = 0;
            }
            Console.Write(answer);
        }
    }
}
