using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2902
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            
            for(int i = 1; i < input.Length; i++)
            {
                if (input[i] == '-')
                    sb.Append(input[i + 1]);
            }
            Console.WriteLine(sb);
        }
    }
}
