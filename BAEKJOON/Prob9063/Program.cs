using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob9063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max_x = int.MinValue;
            int max_y = int.MinValue;
            int min_x = int.MaxValue;
            int min_y = int.MaxValue;

            int n = int.Parse(Console.ReadLine());
            for(int i=0; i< n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (int.Parse(input[0]) > max_x)
                    max_x = int.Parse(input[0]);
                if (int.Parse(input[1]) > max_y)
                    max_y = int.Parse(input[1]);
                if (int.Parse(input[0]) < min_x)
                    min_x = int.Parse(input[0]);
                if (int.Parse(input[1]) < min_y)
                    min_y = int.Parse(input[1]);
            }
            Console.WriteLine("{0}",(max_x -min_x) * (max_y - min_y));
        }
    }
}
