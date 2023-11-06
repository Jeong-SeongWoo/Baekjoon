using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10951
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                    break;
                string[] output = input.Split();
                sb.Append(int.Parse(output[0]) + int.Parse(output[1]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
