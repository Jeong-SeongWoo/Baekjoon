using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 

            int T = int.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string[] num = Console.ReadLine().Split();
                int sum = int.Parse(num[0]) + int.Parse(num[1]);
                sb.Append("Case #" + (i + 1) + ": " +  num[0] + " + " + num[1] + " = " + sum + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
