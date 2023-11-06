using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string total = Console.ReadLine();
            string count = Console.ReadLine();

            int cnt = int.Parse(count);
            int sum = 0;

            for (int i = 0; i < cnt; i++)
            {
                string[] bill = Console.ReadLine().Split();
                sum += int.Parse(bill[0]) * int.Parse(bill[1]);
            }

            if (sum == int.Parse(total))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
