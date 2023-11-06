using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Queue<int> q = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            int last = 0;

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push":
                        q.Enqueue(int.Parse(input[1]));
                        last = int.Parse(input[1]);
                        continue;
                    case "pop":
                        if(q.Count > 0)
                        {
                            sb.AppendLine(q.Dequeue().ToString());
                            continue;
                        }
                        else
                        {
                            sb.AppendLine("-1");
                            continue;
                        }
                    case "size":
                        sb.AppendLine(q.Count.ToString());
                        continue;
                    case "empty":
                        if(q.Count > 0)
                        {
                            sb.AppendLine("0");
                            continue;
                        }
                        else
                        {
                            sb.AppendLine("1");
                            continue;
                        }
                    case "front":
                        if (q.Count > 0)
                        {
                            sb.AppendLine(q.Peek().ToString());
                            continue;
                        }
                        else
                        {
                            sb.AppendLine("-1");
                            continue;
                        }
                    case "back":
                        if (q.Count > 0)
                        {
                            sb.AppendLine(last.ToString());
                            continue;
                        }
                        else
                        {
                            sb.AppendLine("-1");
                            continue;
                        }

                }
            }
            Console.WriteLine(sb);
        }
    }
}
