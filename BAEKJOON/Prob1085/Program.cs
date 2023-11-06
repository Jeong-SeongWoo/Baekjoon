using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prob1085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int h = int.Parse(input[3]);

            int minx;
            int miny;

            minx = w - x >= x ? x : w - x;
            miny = h - y >= y ? y : h - y;

            Console.WriteLine(minx >= miny ? miny : minx);
        }
    }
}
