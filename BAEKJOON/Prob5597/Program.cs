using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5597
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean[] check = Enumerable.Repeat(false, 30).ToArray();
            
            for (int i = 0; i < 28; i++)
            {
                string student = Console.ReadLine();
                check[int.Parse(student) -1] = true;
            }

            for (int i = 0;i < check.Length; i++)
            {
                if(check[i] == false)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
