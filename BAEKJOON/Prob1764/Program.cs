using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1764
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<string, int> people = new Dictionary<string, int>();
            SortedSet<string> names = new SortedSet<string>();
            int answer = 0;

            for (int i=0; i < input[0]; i++)
                people.Add(sr.ReadLine(), 1);

            for(int i=0; i < input[1]; i++)
            {
                string name = sr.ReadLine();
                if (people.ContainsKey(name))
                {
                    answer += people[name];
                    names.Add(name);
                }
            }

            sw.WriteLine(answer);
            foreach (string name in names)
                sw.WriteLine(name);
            sr.Close();
            sw.Close();
        }
    }
}
