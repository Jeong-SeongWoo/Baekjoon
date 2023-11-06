using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                       string num1 = input[0].ToString() + input[1].ToString();
                       string num2 = input[2].ToString() + input[3].ToString();

                       Console.WriteLine(long.Parse(num1) + long.Parse(num2));*/

            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(long.Parse(input[0].ToString() + input[1].ToString()) + long.Parse(input[2].ToString() + input[3].ToString()));
        }
    }
}
