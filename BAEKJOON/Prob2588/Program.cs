using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Prob2588
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int a = int.Parse(num2) / 100;
            int b = int.Parse(num2) % 10;

            Console.WriteLine(int.Parse(num1) * b);
            Console.WriteLine(int.Parse(num1) * ((int.Parse(num2) - (100 * a) - b) / 10));
            Console.WriteLine(int.Parse(num1) * a);
            Console.WriteLine(int.Parse(num1) * int.Parse(num2));
        }
    }
}
