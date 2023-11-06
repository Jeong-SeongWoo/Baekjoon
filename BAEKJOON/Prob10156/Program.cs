using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] input = Console.ReadLine().Split();
            
            int cost = int.Parse(input[0]);
            int buy  = int.Parse(input[1]);
            int money = int.Parse(input[2]);

            if(cost * buy > money)
            {
                Console.WriteLine(cost * buy - money);
            }
            else
            {
                Console.WriteLine("0");
            }
            */
            string[] input = Console.ReadLine().Split();

            int result = int.Parse(input[0]) * int.Parse(input[1]) - int.Parse(input[2]);
    

            if (result > 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
