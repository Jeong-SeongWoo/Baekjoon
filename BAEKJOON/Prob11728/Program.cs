using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11728
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int cnt = 0, i = 0, j = 0;
            int[] arrsize = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] answer = new int[a.Length + b.Length];

            while(cnt < answer.Length)
            {
                if (i == a.Length)
                {
                    answer[cnt] = b[j];
                    j++;
                    cnt++;
                    continue;
                }
                else if(j == b.Length)
                {
                    answer[cnt] = a[i];
                    i++;
                    cnt++;
                    continue;
                }
;               if (a[i] >= b[j])
                {
                    answer[cnt] = b[j];
                    j++;
                    cnt++;
                }
                else
                {
                    answer[cnt] = a[i];
                    i++;
                    cnt++;
                }
            }

            for(int k = 0; k < answer.Length; k++)
                sw.Write(answer[k] + " ");

            sw.Close();
            sr.Close();
        }
    }
}
