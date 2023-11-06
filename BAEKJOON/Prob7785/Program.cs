using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7785
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            SortedSet<string> s = new SortedSet<string>();

            for(int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();

                if (input[1] == "enter")
                    s.Add(input[0]);
                else
                    s.Remove(input[0]);
            }

            string[] answer = s.Reverse().ToArray();

            foreach(var item in answer)
                sw.WriteLine(item);
            
            sw.Close();
            sr.Close();
        }
    }
}
