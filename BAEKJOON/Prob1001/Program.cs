using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] Num = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(Num[0]) - int.Parse(Num[1]));
        }
    }
}
