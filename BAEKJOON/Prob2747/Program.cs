using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2747
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] num = new int[n + 1];
            num[0] = 0; 
            num[1] = 1;

            for(int i = 2; i <= n; i++)
                num[i] = num[i - 2] + num[i - 1];
            Console.WriteLine(num[n]);
        }
    }
}
