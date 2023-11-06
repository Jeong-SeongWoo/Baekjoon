using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob27866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int order = int.Parse(Console.ReadLine());

            Console.WriteLine(word[order-1]);
        }
    }
}
