using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();

            if (int.Parse(year) % 400 == 0)
                Console.WriteLine("1");
            
            else if (int.Parse(year) % 4 == 0 &&  int.Parse(year) % 100 != 0)
                Console.WriteLine("1");
            
            else
                Console.WriteLine("0");
        }
    }
}
