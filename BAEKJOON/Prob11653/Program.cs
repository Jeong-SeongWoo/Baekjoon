using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11653
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sb.AppendLine(Convert.ToString(i));
                    n /= i;
                    i--;
                }
            }
            Console.Write(sb);
        }
    }
}
