using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 하기 주석 버전은 문자열 뒤 공백까지 표현하여 오답처리 됨.
            /*
            StringBuilder sb = new StringBuilder();

            string cnt = Console.ReadLine();
            int N = int.Parse(cnt);
            char[] stars = new char[2 * N - 1];
            
            stars[N - 1] = '*';
            for (int i = 0; i < N; i++)
            {
                stars[(N - 1) + i] = '*';
                stars[(N - 1) - i] = '*';
                for (int j = 0; j < stars.Length; j++)
                {
                    sb.Append(stars[j]);
                }
                sb.Append("\n");
            }
            for (int i = 0;  i <  N; i++)
            {
                stars[i] = ' ';
                stars[stars.Length - 1 - i] = ' ';
                for (int j = 0; j < stars.Length; j++)
                {
                    sb.Append(stars[j]);
                }
                if (i == N - 2)
                    break;
                else
                    sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
            */

            StringBuilder sb = new StringBuilder();
            int N  = int.Parse(Console.ReadLine());
            int cnt = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = (N-1)-i; j > 0 ; j--)
                    sb.Append(" ");
                for (int k = 1; k <= cnt; k++)
                    sb.Append("*");
                sb.Append("\n");
                cnt += 2;
                if (i == N - 1)
                    cnt -= 4;
            }

            for (int i = 0;i < N-1; i++)
            {
                for (int j= 0; j < i+1; j++)
                    sb.Append(" ");
                for (int k = cnt; k>0; k--)
                    sb.Append("*");
                if(i<N-1)
                    sb.Append("\n");
                cnt -= 2;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
