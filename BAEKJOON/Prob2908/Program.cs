using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2908
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] compare = Console.ReadLine().Split();
            int a = int.Parse(compare[0]);
            int b = int.Parse(compare[1]);

            if(a % 10 > b % 10)
            {
                Console.WriteLine(compare[0].Reverse().ToArray());
            }
            else if(a%10 == b % 10)
            {
                if (a % 100 > b % 100)
                {
                    Console.WriteLine(compare[0].Reverse().ToArray());
                }
                else if (a%100 == b % 100)
                {
                    if(a /100 > b / 100)
                    {
                        Console.WriteLine(compare[0].Reverse().ToArray());
                    }
                    else
                    {
                        Console.WriteLine(compare[1].Reverse().ToArray());
                    }
                }
                else
                {
                    Console.WriteLine(compare[1].Reverse().ToArray());
                }
            }
            else
            {
                Console.WriteLine(compare[1].Reverse().ToArray());
            }
        }
    }
}
