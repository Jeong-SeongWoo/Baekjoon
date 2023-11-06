using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] result = Enumerable.Repeat(false, 42).ToArray();
            int cnt = 0;

            for (int i = 0; i < 10; i++)
            {
                string num = Console.ReadLine();
                int rest = int.Parse(num) % 42;
                result[rest] = true;
            }

            for (int i = 0;i < result.Length;i++)
            {
                if (result[i] == true)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
