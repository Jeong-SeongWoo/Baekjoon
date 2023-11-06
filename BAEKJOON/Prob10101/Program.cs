using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angles = new int[3];
            int cnt = 0;
            int sum = 0;
            
            for (int i = 0; i < 3; i++)
            {
                angles[i] = int.Parse(Console.ReadLine());
                sum += angles[i];
                if (i > 0 && angles[i] == angles[i - 1])
                    cnt++;
                else if (i == 2 && angles[i] == angles[i - 2])
                    cnt++;
            }
            
            if(sum != 180)
                Console.WriteLine("Error");
            else
            {
                if( cnt == 2)
                    Console.WriteLine("Equilateral");
                else if (cnt == 1)
                    Console.WriteLine("Isosceles");
                else
                    Console.WriteLine("Scalene");
            }
        }
    }
}
