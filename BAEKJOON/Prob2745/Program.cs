using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2745
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string num = input[0];
            int notation = int.Parse(input[1]);
            int answer = 0;
            int i = num.Length;
            int k = 0;

            for (i = i - 1; i >= 0; i--) //5 4
            {
                int tmp = 1;
                for (int j= 0;  j < i; j++) // 0~4  0~3
                {
                    tmp *= notation;
                }
                if (num[k] >= 'A' && num[k] <= 'Z')
                {
                    answer += Convert.ToInt32(num[k] - 55) * tmp;
                    k++;
                }
                else
                {
                    answer += Convert.ToInt32(num[k] - 48) * tmp;
                    k++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
