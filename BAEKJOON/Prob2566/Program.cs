using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[9, 9];
            int[] answer = new int[2];
            int max = 0;

            for(int i = 0; i < 9; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j = 0; j < 9; j++)
                {
                    nums[i, j] = int.Parse(input[j]);
                    if (nums[i, j] >= max)
                    {
                        max = nums[i, j];
                        answer[0] = i + 1;
                        answer[1] = j + 1;
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("{0} {1}", answer[0], answer[1]);
        }
    }
}
