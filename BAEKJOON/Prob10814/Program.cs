using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10814
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            List<Tuple<int, string>> list = new List<Tuple<int, string>>();

            int n = int.Parse(sr.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();
                list.Add(new Tuple<int, string>(int.Parse(input[0]), input[1]));
            }

            var output = list.OrderBy(x => x.Item1).ToList();

            foreach(var item in output)
                sw.WriteLine($"{item}".Replace("(",null).Replace(")",null).Replace(",", null));

            sw.Close();
            sr.Close();
        }
    }
}
