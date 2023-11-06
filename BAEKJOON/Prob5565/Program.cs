using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5565
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tot = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < 9; i++)
            {
                int price = int.Parse(Console.ReadLine());
                tot -= price;
            }
            Console.WriteLine(tot);
        }
    }
}
