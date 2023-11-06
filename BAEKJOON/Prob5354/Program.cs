using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5354
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int box = int.Parse(Console.ReadLine());

                for (int j = 0; j < box; j++)
                {
                    for(int k = 0; k < box; k++)
                    {
                        if (j == 0 || j == box - 1)
                            sb.Append('#');
                        else if (k > 0 && k < box - 1)
                            sb.Append('J');
                        else
                            sb.Append('#');
                    }
                    sb.Append('\n');
                }
                sb.Append('\n');
            }
            Console.Write(sb);
        }
    }
}
