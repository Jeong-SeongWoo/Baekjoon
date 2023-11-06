using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prob5800
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0; i < n; i++)
            {
                sb.AppendLine("Class " + (i + 1));
                int largestgap = int.MinValue;
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(input, 1, input[0]);
                int sum = input[1], avg = 0;

                for(int j = 2; j < input.Length; j++)
                {
                    sum += input[j];
                    if (input[j] - input[j - 1] > largestgap )
                    {
                        largestgap = input[j] - input[j - 1];
                    }
                }
                avg = sum / n;
                sb.AppendLine("Max " + input[input[0]] + ", Min " + input[1] + ", Largest gap " + largestgap);
            }
            Console.WriteLine(sb);
        }
    }
}
