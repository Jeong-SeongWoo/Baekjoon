using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prob1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                BigInteger[] input = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
                BigInteger multiple = input[0];

                for (int j = 0; j < input[1] - 1; j++)
                    input[0] *= multiple;
                input[0] %= 10;

                if (input[0] == 0)
                    sb.AppendLine("10");
                else
                    sb.AppendLine(input[0].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
