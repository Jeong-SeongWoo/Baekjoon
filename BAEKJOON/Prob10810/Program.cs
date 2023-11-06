using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] problem = Console.ReadLine().Split(); // 5 4 입력
            int N = int.Parse(problem[0]); //5
            int M = int.Parse(problem[1]); //4
            int[] answer = new int[N]; //answer[5]

            for (int i= 0; i < M; i++) // i = 0 i < 4
             {
                string[] putinball = Console.ReadLine().Split(); // 바구니번호. 공의 숫자 입력
                for (int j = int.Parse(putinball[0]) - 1; j < int.Parse(putinball[1]); j++)
                {
                    answer[j] = int.Parse(putinball[2]);
                }
            }
            
            for (int i= 0;i < N; i++)
            {
                Console.Write(answer[i] + " ");
            }
        }
    }
}
