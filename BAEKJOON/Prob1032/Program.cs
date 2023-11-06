using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            char output = ' ';
            string answer = "";

            if (n == 1)
            {
                input[0] = Console.ReadLine();
                answer = input[0];
            }

            else
            {
                for (int i = 0; i < n; i++)
                    input[i] = Console.ReadLine();

                for (int i = 0; i < input[0].Length; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        if (input[j][i] != input[j - 1][i])
                        {
                            output = '?';
                            break;
                        }
                        else
                        {
                            output = input[j][i];
                        }
                    }
                    answer += output;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
