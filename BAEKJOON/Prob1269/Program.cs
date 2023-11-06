using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prob1269
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] a_arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] b_arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int answer = a_arr.Except(b_arr).Count() + b_arr.Except(a_arr).Count();
            
            sw.Write(answer);
            sw.Close();
            sr.Close();
        }
    }
}
