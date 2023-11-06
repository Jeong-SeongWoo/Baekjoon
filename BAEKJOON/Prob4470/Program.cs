using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sentence;
            StringBuilder sb = new StringBuilder();

            for(int i = 0;i<n; i++)
            {
                sentence = Console.ReadLine();
                sb.AppendLine((i+1)+". " + sentence);
            }
            Console.WriteLine(sb);
        }
    }
}
