using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob24265
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * (n - 1) / 2);
            Console.WriteLine("2");
        }
    }
}
