using System;
using System.Text;

namespace Prob10952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] a = {"1","1"};
            while (true)
            {
                a = Console.ReadLine().Split();
                
                if (a[0] == "0" && a[1] == "0")
                    break;
                else
                    sb.Append((int.Parse(a[0]) + int.Parse(a[1])) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
