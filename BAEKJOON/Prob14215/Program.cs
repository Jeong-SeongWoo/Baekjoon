using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int max = int.MinValue;
            int sum = 0;
            int answer;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i]);
                if (int.Parse(input[i]) > max)
                    max = int.Parse(input[i]);
            }
            if ((sum - max) <= max)
                answer = (sum - max) + (sum - max - 1);
            else
                answer = sum;
        
            Console.WriteLine(answer);
        }
    }
}
