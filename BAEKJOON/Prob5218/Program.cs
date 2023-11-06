using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();

                sw.Write("Distances: ");
                for(int j = 0; j < input[0].Length; j++)
                {
                    if (input[0][j] <= input[1][j])
                        sw.Write(input[1][j] - input[0][j] + " ");
                    else
                        sw.Write(input[1][j] + 26 - input[0][j] + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
            sr.Close();
        }
    }
}
