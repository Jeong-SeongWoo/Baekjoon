using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int sum = 0;

            a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);

            for (int i = 0; i < n; i++)
                sum += a[i] * b[i];
            Console.WriteLine(sum);
        }
    }
}
