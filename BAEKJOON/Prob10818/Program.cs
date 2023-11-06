using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();

            int min = int.Parse(arr[0]);
            int max = int.Parse(arr[0]);

            for (int i = 1; i < cnt; i++)
            {
                if (int.Parse(arr[i]) < min)
                    min = int.Parse(arr[i]);
                if (int.Parse(arr[i]) > max)
                    max = int.Parse(arr[i]);
            }
            Console.WriteLine(min + " " + max);
        }
    }
}
