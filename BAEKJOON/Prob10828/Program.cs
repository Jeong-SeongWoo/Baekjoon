using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1]));
                        continue;
                    case "pop":
                        if (stack.Count == 0)
                        {
                            sb.AppendLine("-1");
                            continue;
                        }
                        else
                        {
                            sb.AppendLine(stack.Pop().ToString());
                            continue;
                        }
                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        continue;
                    case "empty":
                        if (stack.Count == 0)
                        {
                            sb.AppendLine("1");
                            continue;
                        }
                        else
                        {
                            sb.AppendLine("0");
                            continue;
                        }
                    case "top":
                        if (stack.Count == 0)
                        {
                            sb.AppendLine("-1");
                            continue;
                        }
                        else
                        {
                            sb.AppendLine(stack.Peek().ToString());
                            continue;
                        }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
