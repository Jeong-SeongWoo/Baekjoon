using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10998
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(num[0]) * int.Parse(num[1]));
        }
    }
}
