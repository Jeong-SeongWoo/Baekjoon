using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[5];
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
                if (score[i] <= 40)
                    sum += 40;
                else
                    sum += score[i];
            }
            Console.WriteLine(sum / 5);
        }
    }
}
