using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11718
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string sentence = Console.ReadLine();
                if(sentence == null)
                    break;
                sb.AppendLine(sentence);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
