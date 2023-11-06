using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Prob10813
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int tmp;
            int[] num = new int[N];

            for(int i = 0; i < N; i++)
                num[i] = i + 1;

            for(int i = 0;i < M; i++)
            {
                string[] change = Console.ReadLine().Split();
                tmp = num[int.Parse(change[0]) - 1];
                num[int.Parse(change[0]) - 1] = num[int.Parse(change[1])-1];
                num[int.Parse(change[1]) - 1] = tmp;
            }
            
            for (int i = 0; i < num.Length ; i++)
                Console.Write(num[i] + " ");
        }
    }
}
