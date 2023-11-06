using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                int max = int.MinValue;
                int sum = 0;
                int samecnt = 0;
                string[] triangle = Console.ReadLine().Split();

                if (triangle[0] == "0")
                    break;

                for(int i = 0;i < 3; i++)
                {
                    sum += int.Parse(triangle[i]);
                    if (int.Parse(triangle[i]) > max)
                    {
                        max = int.Parse(triangle[i]);
                    }
                    for(int j = i + 1;j < 3; j++)
                    {
                        if (int.Parse(triangle[i]) == int.Parse(triangle[j]))
                            samecnt++;
                    }
                }

                if (max >= sum - max)
                    sb.AppendLine("Invalid");

                else 
                {
                    if (samecnt == 3)
                        sb.AppendLine("Equilateral");
                    else if (samecnt == 1)
                        sb.AppendLine("Isosceles");
                    else
                        sb.AppendLine("Scalene");
                }
            }
            Console.Write(sb);
        }
    }
}
