using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2563
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] check = new bool[100, 100];
            int answer = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    check[i, j] = false;
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n; i++)
            {
                string[] size = Console.ReadLine().Split();
                for(int j = int.Parse(size[0]);j < int.Parse(size[0]) + 10 ;j++)
                {
                    for(int k = int.Parse(size[1]);k < int.Parse(size[1]) + 10; k++)
                    {
                        check[j, k] = true;
                    }
                }
            }

            for (int i = 0; i<100 ; i++)
            {
                for( int j = 0; j < 100; j++)
                {
                    if (check[i, j] == true)
                    {
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}