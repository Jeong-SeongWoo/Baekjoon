using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob18870
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            var answer = new Dictionary<int, int>();


            int n = int.Parse(sr.ReadLine());
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] prob = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                prob[i] = arr[i];
            int cnt = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!answer.ContainsKey(arr[i]))
                {
                    answer.Add(arr[i], cnt);
                    cnt++;
                }
                else
                {
                    continue;
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                sw.Write(answer[prob[i]] + " ");
            }
            sw.Close();
            sr.Close();
        }
    }
}
