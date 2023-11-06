using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2675
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < cnt; i++)
            {
                string[] ex = Console.ReadLine().Split();
                int repeat = int.Parse(ex[0]);
                string sentence = ex[1];

                for (int j = 0; j < sentence.Length; j++)
                {
                    for (int k = 0; k < repeat; k++)
                    {
                        sb.Append(sentence[j]);
                    }
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
