using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2750
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine()); 
            }

            Array.Sort(nums);

            for (int i = 0;i < nums.Length;i++)
            {
                sb.AppendLine(nums[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
