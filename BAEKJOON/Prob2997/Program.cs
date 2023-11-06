using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2997
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int[] problem = new int[3];
            for(int i = 0;i < 3; i++)
            {
                problem[i] = int.Parse(nums[i]);
            }
            Array.Sort(problem);
            int max = problem[2], mid = problem[1], min = problem[0];
         
            if(max - mid != mid - min)
            {
                if(max - mid > mid - min)
                    Console.WriteLine((mid + max) / 2);
                else
                    Console.WriteLine((mid + min) / 2);
            }
            else
                Console.WriteLine(max + mid - min);
        }
    }
}
