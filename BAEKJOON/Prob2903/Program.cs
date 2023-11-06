using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prob2903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 2;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                answer = answer + answer - 1;

            Console.WriteLine(answer * answer);
        }
    }
}
