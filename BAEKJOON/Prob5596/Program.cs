using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5596
{
    internal class Program
    {
        static int plus(string[] score)
        {
            int result = 0;
            for (int i = 0; i < score.Length; i++)
                result += int.Parse(score[i]);
            return result;
        }

        static int compare(int a, int b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }

        static void Main(string[] args)
        {
            int[] sum = new int[2];
            for(int i = 0; i < 2; i++)
            {
                string[] score = Console.ReadLine().Split();
                sum[i] = plus(score);
            }

            int answer = compare(sum[0], sum[1]);

            Console.WriteLine(answer);
        }
    }
}
