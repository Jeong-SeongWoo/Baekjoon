using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Prob3009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            int[] y = new int[3];
            int answerx, answery;

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }

            Array.Sort(x);
            Array.Sort(y);

            answerx = x[0] == x[1] ? x[2] : x[0];
            answery = y[0] == y[1] ? y[2] : y[0];

            Console.WriteLine("{0} {1}",answerx,answery);
        }
    }
}
