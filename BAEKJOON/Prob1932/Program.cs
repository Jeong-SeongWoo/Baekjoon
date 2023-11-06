using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1932
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int[,] answer = new int[n,n];
            answer[0,0] = int.Parse(Console.ReadLine());

            for(int i = 1; i < n ; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for(int j = 0; j< input.Length; j++)
                {
                    if (j == 0)
                        answer[i,j] = answer[i - 1,0] + input[0];
                    else if (j == input.Length - 1)
                        answer[i, j] = answer[i - 1, j - 1] + input[j];
                    else
                        answer[i, j] = answer[i - 1, j - 1] + input[j] > answer[i - 1, j] + input[j] ?
                            answer[i - 1, j - 1] + input[j] : answer[i - 1, j] + input[j];
                }
            }

            for(int i = 0; i <n; i++)
            {
                if (answer[n - 1, i] > max)
                    max = answer[n - 1, i];
            }
            Console.WriteLine(max);
        }
    }
}
