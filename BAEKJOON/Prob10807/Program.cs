using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            int[] num = new int[cnt];
            string[] array = Console.ReadLine().Split();
            int targetnum = int.Parse(Console.ReadLine());
            int answer = 0;
            
            for (int i = 0; i < cnt; i++)
            {
                num[i] = int.Parse(array[i]);
                if (targetnum == num[i])
                    answer++;
            }
            Console.WriteLine(answer);
        }
    }
}
