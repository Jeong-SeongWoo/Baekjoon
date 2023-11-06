using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int get = int.Parse((Console.ReadLine()));
                sb.Append(get / 25 + " ");
                get %= 25;
                sb.Append(get / 10 + " ");
                get %= 10;
                sb.Append(get / 5 + " ");
                get %= 5;
                sb.Append(get + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
