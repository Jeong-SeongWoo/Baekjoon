using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob30017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int patty = int.Parse(input[0]);
            int cheese = int.Parse(input[1]);

            if (patty > cheese)
            {
                patty = cheese + 1;
                Console.Write(patty + cheese);
            }
            else
            {
                cheese = patty - 1;
                Console.Write(patty + cheese);
            }
        }
    }
}
