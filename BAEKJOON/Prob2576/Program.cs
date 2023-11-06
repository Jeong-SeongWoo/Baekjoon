using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[7];
            int sum = 0, min = int.MaxValue;
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] % 2 != 0)
                {
                    sum += num[i];
                    if (num[i] < min)
                        min = num[i];
                }
            }
            if (sum == 0)
                Console.WriteLine("-1");
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
