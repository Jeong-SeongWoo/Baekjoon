using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1264
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string prob = Console.ReadLine();
               
                if (prob == "#")
                    break;

                int answer = 0;

                for (int  i = 0; i < prob.Length; i++)
                {
                    switch(prob[i])
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            answer++;
                            continue;
                        default:
                            continue;
                    }
                }
                sb.AppendLine(answer.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
