using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14681
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            if(int.Parse(x) < 0)
            {
                if(int.Parse(y) < 0)
                    Console.WriteLine("3");
                else
                    Console.WriteLine("2");
            }
            else
            {
                if(int.Parse(y) < 0)
                    Console.WriteLine("4");
                else
                    Console.WriteLine("1");
            }
        }
    }
}
