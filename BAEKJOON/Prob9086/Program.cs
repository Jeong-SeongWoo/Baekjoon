using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob9086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                string word = Console.ReadLine();
                sb.Append(word[0] + "" + word[word.Length - 1] + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}