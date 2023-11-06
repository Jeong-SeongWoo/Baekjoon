using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1598
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int vertical, horizontal,answer;

            //입력 받은 수 중 4의 배수가 있을 경우
            if (n % 4 == 0 || m % 4 == 0)
            {
                if(n % 4 == 0 && m % 4 != 0)
                {
                    vertical = 4 - m % 4;
                    horizontal = (n / 4) - (m / 4 + 1);
                }
                else if(m % 4 == 0 && n % 4 != 0)
                {
                    vertical = (n % 4) - 4;
                    horizontal = (n / 4 + 1) - (m / 4);
                }
                else
                {
                    vertical = 0;
                    horizontal = (n / 4) - (m / 4);
                }
            }
            //입력 받은 수 중 4의 배수가 없을 경우
            else
            {
                vertical = n % 4 - m % 4;

                horizontal = (n / 4 + 1) - (m / 4 + 1);
            }
            
            horizontal = Math.Abs(horizontal);
            vertical = Math.Abs(vertical);
            answer = vertical + horizontal;
            Console.WriteLine(answer);
        }
    }
}
