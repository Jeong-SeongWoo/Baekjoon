using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob19532
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for(int i = -999; i< 1000; i++)
            {
                for(int j = -999; j< 1000; j++)
                {
                    if ((input[0] * i) + (input[1] * j) == input[2] && (input[3] * i) + (input[4] * j) == input[5])
                    {
                        Console.WriteLine("{0} {1}",i,j);
                    }
                }
            }
        }
    }
}
