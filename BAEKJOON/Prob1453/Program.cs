using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1453
{
    internal class Program
    {
        static int compare(int[] arr, int customer, int location)
        {
            for(int i = 0; i < location; i++)
            {
                if (arr[i] == customer)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] seat = new int[n];
            seat = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int answer = 0;

            for(int i=1;i<seat.Length; i++)
            {
                answer += compare(seat, seat[i], i);
            }
            Console.WriteLine(answer);
        }
    }
}
