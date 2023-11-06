using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11651
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                arr[i] = new int[] { input[0], input[1] };
            }
            var temp = arr.OrderBy(y => y[1]).ThenBy(y => y[0]);
            int[][] answer = temp.ToArray();

            for (int i = 0; i < n; i++)
            {
                sw.WriteLine(answer[i][0] + " " + answer[i][1]);
            }
            sr.Close();
            sw.Close();
        }
    }
}
