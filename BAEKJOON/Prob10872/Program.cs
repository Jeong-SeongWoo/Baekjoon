using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10872
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 1;
            
            for(int i=0; i<n; i++)
            {
                answer = answer * (i + 1);
            }
            Console.WriteLine(answer);
        }
    }
}
