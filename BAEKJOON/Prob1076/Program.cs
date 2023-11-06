using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1076
{
    internal class Program
    {
        static int colorcode(string color)
        {
            string[] colors = { 
                "black", "brown", "red",
                "orange", "yellow", "green",
                "blue", "violet", "grey", "white"};

            for(int i = 0; i < colors.Length; i++)
            {
                if (color == colors[i])
                    return i;
            }
            return 0;
        }
        
        static int multiple(long n)
        {
            int[] nums = {
                1, 10, 100, 1000, 10000,
                100000, 1000000, 10000000,
                100000000, 1000000000 };
            return nums[n];
        }

        static void Main(string[] args)
        {
            int[] code = new int[3];
            long answer = 0;
            for (int i = 0; i < 3; i++)
            {
                string color = Console.ReadLine();
                code[i] = colorcode(color);
            }

            answer = (code[0] * 10 + code[1]) * (long)multiple(code[2]);

            Console.WriteLine(answer);
        }
    }
}
