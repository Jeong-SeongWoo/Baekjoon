using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8958
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = sr.ReadLine();
                int cnt = 0, tot = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'O')
                    {
                        cnt++;
                        tot += cnt;
                    }
                    else
                    {
                        cnt = 0;
                    }
                }
                sw.WriteLine(tot);
            }
            sw.Close();
            sr.Close();
        }
    }
}
