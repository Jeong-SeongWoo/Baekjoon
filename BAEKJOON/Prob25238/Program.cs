using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob25238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double defenceignore = double.Parse(input[0]) * double.Parse(input[1]) / 100;

            if (double.Parse(input[0]) - defenceignore >= 100)
                Console.WriteLine("0");
            else
                Console.WriteLine("1");
        }
    }
}
