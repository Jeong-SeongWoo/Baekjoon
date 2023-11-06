using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11637
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] vote = new int[n];
                int sum = 0, cnt = 0, max = int.MinValue; ;
                
                for(int j = 0; j < n; j++)
                {
                    vote[j] = int.Parse(Console.ReadLine());
                    sum += vote[j];
                    if (vote[j] > max)
                    {
                        max = vote[j];
                        cnt = j;
                    }
                }
                
                Array.Sort(vote);

                if (vote[n - 2] == vote[n - 1])
                    sb.AppendLine("no winner");
                else if (vote[n - 1] > sum / 2)
                    sb.AppendLine("majority winner " + (cnt + 1));
                else if (vote[n - 1] <= sum / 2)
                    sb.AppendLine("minority winner " + (cnt + 1));
            }
            Console.WriteLine(sb);
        }
    }
}
