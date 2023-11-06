using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob24267
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * (n - 1) * (n - 2) / 6 );
            Console.WriteLine("3");
        }
    }
}
