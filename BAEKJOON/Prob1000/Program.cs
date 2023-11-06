using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 풀이1
            //string[] nums = Console.ReadLine().Split();
            //Console.WriteLine(int.Parse(nums[0]) + int.Parse(nums[1]));


            //풀이2
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int a = Convert.ToInt32(arrInput[0]);
            int b = Convert.ToInt32(arrInput[1]);

            Console.WriteLine(a + b);
        }
    }
}
