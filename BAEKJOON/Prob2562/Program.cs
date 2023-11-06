using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2562
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[9];
            int max = 0;
            int cnt = 0;

            for(int i = 0 ; i < 9 ; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] > max)
                {
                    max = num[i];
                    cnt = i + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(cnt);
        }
    }
}
