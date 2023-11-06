using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            for (int i =1; i < 10; i++)
            {
                Console.WriteLine(num + " * " + i +" = "+ (int.Parse(num) * i));
            }
        }
    }
}
