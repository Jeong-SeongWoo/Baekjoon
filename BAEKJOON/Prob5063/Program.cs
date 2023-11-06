using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int cnt = int.Parse(Console.ReadLine());
            for(int i = 0; i < cnt; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (int.Parse(input[0]) > int.Parse(input[1]) - int.Parse(input[2]))
                    sb.AppendLine("do not advertise");
                else if (int.Parse(input[0]) < int.Parse(input[1]) - int.Parse(input[2]))
                    sb.AppendLine("advertise");
                else
                    sb.AppendLine("does not matter");
            }

            Console.Write(sb);
        }
    }
}
