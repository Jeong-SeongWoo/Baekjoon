using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                sb.AppendLine(Convert.ToString(i));
            }
            Console.WriteLine(sb);
        }
    }
}
