using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            /*
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            Console.WriteLine("{0} {1}", k / m, k % m);
            */
            Console.WriteLine("{0} {1}", int.Parse(input[2]) / int.Parse(input[1]), int.Parse(input[2]) % int.Parse(input[1]));

        }
    }
}
