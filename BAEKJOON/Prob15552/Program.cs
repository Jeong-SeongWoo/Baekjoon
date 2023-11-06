using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Prob15552
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < T; i++)
            {
                string[] num = Console.ReadLine().Split();
                sb.Append(int.Parse(num[0]) + int.Parse(num[1]) + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
