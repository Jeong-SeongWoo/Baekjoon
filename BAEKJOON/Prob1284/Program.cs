using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            while (true)
            {
                int centimeter = 1;
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                for(int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '1')
                        centimeter += 2;
                    else if (input[i] == '0')
                        centimeter += 4;
                    else
                        centimeter += 3;
                    
                    centimeter++;
                }
                sb.AppendLine(centimeter.ToString());
            }
            Console.Write(sb);
        }
    }
}
