using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prob11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            Console.WriteLine(long.Parse(nums[0]) + long.Parse(nums[1]) + long.Parse(nums[2]));
        }
    }
}
