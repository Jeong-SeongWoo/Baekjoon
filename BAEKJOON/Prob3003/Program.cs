using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] need = new int[] { 1, 1, 2, 2, 2, 8 };
            string[] have = Console.ReadLine().Split();
            int[] answer = new int[6];

            for (int i = 0; i < need.Length; i++)
            {
                answer[i] = need[i] - int.Parse(have[i]);
                Console.Write(answer[i] + " ");
            }
        }
    }
}
