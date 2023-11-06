using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11383
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] doubleinput = new string[input[0]];
            string answer = "";

            for (int i = 0; i < input[0]; i++)
            {
                string prob = Console.ReadLine();
                for (int j = 0; j < input[1]; j++)
                    doubleinput[i] += prob[j].ToString() + prob[j].ToString();
            }

            for(int i = 0;i < input[0]; i++)
            {
                string compare = Console.ReadLine();
                if (compare != doubleinput[i])
                {
                    answer = "Not Eyfa";
                    break;
                }
                else
                    answer = "Eyfa";
            }

            Console.WriteLine(answer);
        }
    }
}
