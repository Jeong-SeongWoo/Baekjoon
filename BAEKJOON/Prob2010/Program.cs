using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            int answer = 0;

            for(int i = 0; i < n; i++)
                answer += int.Parse(sr.ReadLine());

            sw.WriteLine(answer - (n -1));

            sw.Close();
            sr.Close();
        }
    }
}
