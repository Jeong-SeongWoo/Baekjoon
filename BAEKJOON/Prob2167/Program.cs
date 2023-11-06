using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prob2167
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] intArray = new int[input[0], input[1]];

            for(int i = 0;i< input[0]; i++)
            {
                int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < input[1]; j++)
                    intArray[i, j] = array[j];
            }
            
            int n = int.Parse(Console.ReadLine());
            for(int i= 0; i< n; i++)
            {
                int[] sum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int answer = 0;

                for (int j= sum[0] - 1;j< sum[2]; j++)
                {
                    for(int k = sum[1] - 1; k < sum[3]; k++)
                        answer += intArray[j, k];
                }
                sb.AppendLine(answer.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
