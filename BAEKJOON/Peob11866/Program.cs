using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Queue<int> q = new Queue<int>();
            sb.Append('<');

            for (int i = 0; i < input[0]; i++)
                q.Enqueue(i + 1);

            while (q.Count > 0)
            {
                for (int i = 0;i < input[1]; i++)
                {
                    if (i < input[1] - 1)
                        q.Enqueue(q.Dequeue());
                    else
                    {
                        if ( q.Count == 1)
                            sb.Append(q.Dequeue());
                        else
                            sb.Append(q.Dequeue().ToString() + ", ");
                    }
                }
            }
            sb.Append('>');
            Console.WriteLine(sb);
        }
    }
}
