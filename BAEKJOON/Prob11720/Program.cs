using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string cnt = Console.ReadLine();
            int count = int.Parse(cnt);
            string nums = Console.ReadLine();
            
            for (int i = 0; i < count; i++)
            {
                string a = Convert.ToString(nums[i]);
                sum += int.Parse(a);
            }
            Console.WriteLine(sum);
        }
    }
}
