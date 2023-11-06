using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] number = Console.ReadLine().Split();
            int sum = 0;
           
            for(int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i]) * int.Parse(number[i]);
            }
            Console.WriteLine(sum % 10);
        }
    }
}
