using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob30033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] plan = Console.ReadLine().Split();
            string[] implement = Console.ReadLine().Split();
            int answer = 0;
            for ( int i = 0; i < n; i++) 
            {
                if (int.Parse(plan[i]) <= int.Parse(implement[i]))
                    answer++;
            }

            Console.WriteLine(answer);
        }
    }
}
