using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1181
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            
            int n = int.Parse(sr.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
                list.Add(sr.ReadLine());
            
            var output = list.OrderBy(x => x.Length).ThenBy(x => x).ToArray();

            output = output.Distinct().ToArray();

            for (int i = 0;i < output.Length; i++)
            {
                sw.WriteLine(output[i]);
            }

            sw.Close();
            sr.Close();
        }
    }
}
