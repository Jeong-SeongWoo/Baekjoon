using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11945
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] fishbread = new int[input[0], input[1]];

            for(int i = 0;i < input[0]; i++)
            {
                string left = Console.ReadLine();
                for(int j = 0;j < input[1]; j++)
                    fishbread[i, j] = int.Parse(left[j].ToString());
            }

            for(int i = 0; i < input[0]; i++)
            {
                for(int j = input[1] - 1; j >=0; j--)
                    Console.Write(fishbread[i, j]);
                Console.WriteLine();
            }
        }
    }
}