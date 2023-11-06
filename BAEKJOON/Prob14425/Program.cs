using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            var dic = new Dictionary<string, int>();

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            string[] s = new string[input[0]];
            string[] prob = new string[input[1]];
            int answer = 0;

            for(int i = 0; i < input[0]; i++)
            {
                s[i] = sr.ReadLine();
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], 1);
            }

            for(int i = 0;i < input[1]; i++)
            {
                prob[i] = sr.ReadLine();
                if (dic.ContainsKey(prob[i]))
                    answer++;
            }

            sw.Write(answer);
            sw.Close();
            sr.Close();
        }
    }
}
