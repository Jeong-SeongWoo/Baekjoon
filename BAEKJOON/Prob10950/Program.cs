using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10950
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string T = Console.ReadLine();
            int cnt = int.Parse(T);
            int[] sum = new int[cnt];

            for (int i = 0; i < cnt; i++)
            {
                string[] num = Console.ReadLine().Split();
                sum[i] = int.Parse(num[0]) + int.Parse(num[1]);
            }

            for (int i = 0;i < sum.Length; i++) 
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
