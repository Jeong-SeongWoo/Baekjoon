using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prob10811
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[] baskets = new int[N];
            int tmp;

            for (int i = 0; i < N; i++)
                baskets[i] = i + 1;

            for (int i = 0;i < M; i++)
            {
                string[] reverse = Console.ReadLine().Split();
                int a = int.Parse(reverse[1]) - 1;
                int b = int.Parse(reverse[0]) - 1;

                switch (a - b) 
                {
                    case 0:
                        break;
                    case 1: case 2:
                        tmp = baskets[a];
                        baskets[a] = baskets[b];
                        baskets[b] = tmp;
                        break;
                    default:
                        int c = (a + b + 2) % 2;
                        
                        for (a = a; a > b; a--)
                        {
                            tmp = baskets[a];
                            baskets[a] = baskets[b];
                            baskets[b] = tmp;
                            b++;
                        }
                        break;
                }
            }
            for (int i = 0; i < baskets.Length; i++)
            {
                Console.Write(baskets[i] + " ");
            }
        }
    }
}
