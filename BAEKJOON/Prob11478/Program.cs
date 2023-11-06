using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11478
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> answer = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string makestring = "";
                for (int j = i; j < input.Length; j++)
                {
                    makestring += input[j];
                    answer.Add(makestring);
                }
            }

            Console.WriteLine(answer.Distinct().Count());
        }
    }
}
