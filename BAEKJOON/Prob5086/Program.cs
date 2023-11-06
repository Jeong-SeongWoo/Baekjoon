using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == input[1])
                    break;

                if (int.Parse(input[0]) % int.Parse(input[1]) == 0)
                    sb.AppendLine("multiple");
                else if (int.Parse(input[1]) % int.Parse(input[0]) == 0)
                    sb.AppendLine("factor");
                else
                    sb.AppendLine("neither");
            }
            Console.Write(sb);
        }
    }
}
