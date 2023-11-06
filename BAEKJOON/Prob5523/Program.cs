using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int game = int.Parse(Console.ReadLine());
            int a = 0, b = 0;

            for (int i = 0; i < game; i++)
            {
                string[] score = Console.ReadLine().Split();
                if (int.Parse(score[0]) > int.Parse(score[1]))
                    a++;
                else if (int.Parse(score[0]) < int.Parse(score[1]))
                    b++;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}
