using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob30018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int answer = 0;

            a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                    answer += a[i] - b[i];
            }

            Console.WriteLine(answer);
        }
    }
}
