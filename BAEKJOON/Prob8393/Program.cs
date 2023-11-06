using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8393
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string index = Console.ReadLine();
            int count = int.Parse(index);
            int sum = 0;
            
            for (int i = 1;i <= count; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
