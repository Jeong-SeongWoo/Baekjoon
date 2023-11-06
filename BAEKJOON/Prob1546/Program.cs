using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Prob1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            double total = 0;
            double avg;
            int subject = int.Parse(Console.ReadLine());
            string[] score = new string[subject];
            score = Console.ReadLine().Split();

            for (int i = 0; i < subject; i++)
            {
                if ( int.Parse(score[i]) > max )
                    max = int.Parse(score[i]);
            }

            for (int i = 0;i < score.Length; i++)
            {
                total += double.Parse(score[i]) / max * 100;
            }

            avg = total / subject;
            Console.WriteLine(avg);
        }
    }
}
