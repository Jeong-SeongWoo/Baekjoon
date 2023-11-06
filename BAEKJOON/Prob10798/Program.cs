using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prob10798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];

            for (int i = 0; i < 5; i++)
                words[i] = Console.ReadLine();
           
            for(int i = 0;i < 15;i++)
            {
                for(int j = 0;j < 5;j++)
                {
                    if (i >= words[j].Length)
                        continue;
                    else
                        Console.Write(words[j][i]);
                }
            }
        }
    }
}
