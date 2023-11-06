using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob29751
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            float area  = int.Parse(input[0]) * int.Parse(input[1]) * 0.5f;
            Console.WriteLine("{0:0.0}",area);
        }
    }
}
