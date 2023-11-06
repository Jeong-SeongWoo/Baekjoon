using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob9012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string input = sr.ReadLine();
                Stack<int> stack = new Stack<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '(')
                    {
                        stack.Push(0);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            stack.Push(1);
                            break;
                        }
                        else
                            stack.Pop();
                    }
                }
                if (stack.Count > 0)
                    sb.AppendLine("NO");
                else
                    sb.AppendLine("YES");
            }
            Console.WriteLine(sb);
        }
    }
}
