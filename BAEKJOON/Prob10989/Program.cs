using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10989
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var print = new StreamWriter(Console.OpenStandardOutput());
            
            int n = int.Parse(reader.ReadLine());
            int[] cnt = new int[10001];
            int num;
           
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(reader.ReadLine());
                cnt[num]++;
            }

            for (int i = 0;i < cnt.Length;i++)
            {
                for(int j = 0;j < cnt[i]; j++)
                {
                    print.WriteLine(i);
                }
            }
            print.Close();
        }
    }
}
