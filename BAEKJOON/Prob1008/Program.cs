using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            Console.WriteLine(double.Parse(nums[0]) / double.Parse(nums[1]));
        }
    }
}
