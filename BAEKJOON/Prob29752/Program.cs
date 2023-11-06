using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob29752
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            input = Console.ReadLine().Split();
            int cnt = 0, max = int.MinValue;

            for(int i = 0;i < n; i++)
            {
                if (input[i] == "0")
                    cnt = 0;
                else
                    cnt++;
                if(cnt > max)
                    max = cnt;
            }
            Console.WriteLine(max);
        }
    }
}
