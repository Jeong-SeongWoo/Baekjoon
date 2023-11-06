using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2440
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i < n; i++)
            {
                for(int j = n; j > i; j--)
                {
                    sb.Append("*");
                }
                if (i == n - 1) break;
                else  sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
