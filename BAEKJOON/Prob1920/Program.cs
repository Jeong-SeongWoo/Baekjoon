using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prob1920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int n = int.Parse(sr.ReadLine());
            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int m = int.Parse(sr.ReadLine());
            int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            HashSet<int> prob = new HashSet<int>();
            bool answer;

            for (int i = 0; i < n; i++)
                prob.Add(a[i]);

            for(int i = 0;i < m; i++)
            {
                answer = prob.Contains(b[i]);
                sw.WriteLine(Convert.ToInt32(answer));
            }
            sw.Close();
            sr.Close();
        }
    }
}
