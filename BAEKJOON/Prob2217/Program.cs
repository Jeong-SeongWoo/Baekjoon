using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] rope = new int[n];
            int cnt = n, max = int.MinValue;

            for(int i = 0; i < n; i++)
                rope[i] = int.Parse(Console.ReadLine());

            Array.Sort(rope);

            for (int i = 0; i < n; i++)
            {
                if (rope[i] * cnt > max)
                    max = rope[i] * cnt;
                cnt--;
            }
            Console.WriteLine(max);
        }
    }
}
