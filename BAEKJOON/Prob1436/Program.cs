using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1436
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int numbercheck = 666;

            while (true)
            {
                if (numbercheck.ToString().Contains("666"))
                    cnt++;

                if (cnt == n)
                    break;
                else
                    numbercheck++;
            }
            Console.WriteLine(numbercheck);
        }
    }
}
