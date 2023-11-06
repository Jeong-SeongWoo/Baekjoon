using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] cnt = Console.ReadLine().Split();
            int[] num = new int[int.Parse(cnt[0])];
            string[] example = Console.ReadLine().Split();

            for(int i=0; i<num.Length; i++)
            {
                num[i] = int.Parse(example[i]);
                if (num[i] < int.Parse(cnt[1]))
                {
                     sb.Append(num[i] + " ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
