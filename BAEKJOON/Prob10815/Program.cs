using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10815
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            var prob = new Dictionary<int, int>();

            int n = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for(int i = 0; i < n; i++)
            {
                if (!prob.ContainsKey(input[i]))
                    prob.Add(input[i], 1);
            }

            int m = int.Parse(sr.ReadLine());
            int[] tc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0;i < m; i++)
            {
                if (!prob.ContainsKey(tc[i]))
                    sw.Write("0 ");
                else
                    sw.Write(prob[tc[i]] + " ");
            }
            sw.Close();
            sr.Close();
        }
    }
}
