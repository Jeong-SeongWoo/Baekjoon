using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2587
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }

            Array.Sort(num);
            
            Console.WriteLine(sum / 5);
            Console.WriteLine(num[2]);
        }
    }
}
