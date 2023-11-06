using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11966
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[31];
            int answer = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                var two = Math.Pow(2, i);
                nums[i] = (int)two;
            }

            int n = int.Parse(Console.ReadLine());
           
            for(int i = 0;i < nums.Length;i++)
            {
                if (nums[i] == n)
                {
                    answer = 1;
                    break;
                }
            }
           
            Console.WriteLine(answer);
        }
    }
}
