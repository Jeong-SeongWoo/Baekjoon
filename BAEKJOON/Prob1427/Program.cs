using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1427
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = new int[input.Length];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(input[i].ToString());

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0;i < arr.Length; i++)
                Console.Write(arr[i]);
        }
    }
}
