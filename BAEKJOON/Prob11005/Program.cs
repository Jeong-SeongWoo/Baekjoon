using System;
using System.Text;

namespace Prob11005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();

            int decimalnum = int.Parse(input[0]);
            int notation = int.Parse(input[1]);
            int divide;

            while (true)
            {
                divide = decimalnum % notation;
                if (divide >= 10)
                {
                    sb.Append(Convert.ToChar(divide + 55));
                }
                else
                {
                    sb.Append(divide);
                }
                decimalnum /= notation;
                if (decimalnum == 0) break;
            }
            for(int i = sb.Length - 1; i >= 0; i--)
            {
                if (i == sb.Length - 1)
                {
                    if (sb[i] == '0')
                        continue;
                    else
                        Console.Write(sb[i]);
                }
                else
                    Console.Write(sb[i]);
            }
        }
    }
}
