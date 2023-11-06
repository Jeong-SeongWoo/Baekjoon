using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            int[] answer = Enumerable.Repeat(0,10).ToArray();
            for (int i = 0; i < 3; i++)
                input *= int.Parse(Console.ReadLine());
            string compare = input.ToString();

            for (int i = 0;i < compare.Length;i++)
                answer[int.Parse(compare[i].ToString())]++;

            for(int i = 0; i < answer.Length; i++)
                Console.WriteLine(answer[i]);
        }
    }
}
