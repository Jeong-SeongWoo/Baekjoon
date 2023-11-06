using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob25305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] score = new int[n[0]];
            score = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(score);
            Array.Reverse(score);

            Console.WriteLine(score[n[1] - 1]);
        }
    }
}
