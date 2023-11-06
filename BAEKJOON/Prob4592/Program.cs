using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] arr;

            while (true)
            {
                arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (arr[0] == 0)
                    break;

                sb.Append(arr[1] + " ");
                for (int i = 2; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i - 1])
                        continue;
                    else
                        sb.Append(arr[i] + " ");
                }
                sb.Append("$\n");
            }
            Console.WriteLine(sb);
        }
    }
}
