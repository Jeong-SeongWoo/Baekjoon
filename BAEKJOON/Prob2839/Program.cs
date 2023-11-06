using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2839
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int five = n / 5;
            int three = n / 3;
            int min = int.MaxValue;

            for(int i = 0;i <= five; i++)
            {
                for(int j = 0;j <= three; j++)
                {
                    if(5 * i + 3 * j == n)
                    {
                        if (i + j < min)
                            min = i + j;
                    }
                }
            }
            if (min == int.MaxValue)
                Console.WriteLine("-1");
            else
                Console.WriteLine(min);
        }
    }
}
