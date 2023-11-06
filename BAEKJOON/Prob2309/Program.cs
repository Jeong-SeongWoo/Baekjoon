using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[9];
            int sum = 0;
            int cnti = 0, cntj = 0;

            for(int i = 0; i < 9; i++)
            {
                height[i] = int.Parse(Console.ReadLine());
                sum += height[i];
            }
            
            Array.Sort(height);
            sum -= 100;

            for (int i = 0; i < 9; i++) 
            {
                for (int j = i + 1; j < 9; j++) 
                {
                    if (height[i] + height[j] == sum)
                    {
                        cnti = i;
                        cntj = j;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (i == cnti || i == cntj)
                    continue;
                Console.WriteLine(height[i]);
            }
        }
    }
}
