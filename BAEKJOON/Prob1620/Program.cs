using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Prob1620
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            Dictionary<string, int> pokemon = new Dictionary<string, int>();
            Dictionary<int, string> pokemonno = new Dictionary<int, string>();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0; i < input[0]; i++)
            {
                string data = sr.ReadLine();
                pokemon.Add(data, i + 1);
                pokemonno.Add(i + 1, data);
            }


            for (int i = 0; i < input[1]; i++)
            {
                string prob = sr.ReadLine();
                if (pokemon.ContainsKey(prob))
                    sw.WriteLine(pokemon[prob]);
                else
                    sw.WriteLine(pokemonno[int.Parse(prob)]);
            }
            sw.Close();
            sr.Close();
        }
    }
}
