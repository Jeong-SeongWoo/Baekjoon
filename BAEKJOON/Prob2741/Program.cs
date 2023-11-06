using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
                sb.Append(i + "\n");
           
            Console.WriteLine(sb.ToString());
        }
    }
}
