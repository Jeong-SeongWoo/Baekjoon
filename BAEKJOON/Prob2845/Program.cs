using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2845
{
    internal class Program
    {
        static void calculate(string[] arr, int tot)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int.Parse(arr[i]) - tot).ToString();
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int tot = int.Parse(input[0]) * int.Parse(input[1]);
            string[] news = Console.ReadLine().Split();

            calculate(news, tot);
        }
    }
}
