using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int avg = (input.Sum() - input[0]) / input[0];
                int cnt = 0;
                float percent;

                for(int j = 1; j < input.Length; j++)
                {
                    if (input[j] > avg)
                        cnt++;
                }

                percent = (float)cnt / (float)input[0] * 100;
                sb.AppendLine(percent.ToString("F3") + "%");
            }
            Console.WriteLine(sb);
        }
    }
}
