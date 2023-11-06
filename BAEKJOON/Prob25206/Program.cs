using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Prob25206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[3];
            float sum = 0;
            float score = 0;

            for (int i = 0; i < 20; i++)
            {
                student = Console.ReadLine().Split();

                if (student[2] != "P")
                    score += float.Parse(student[1]);

                switch (student[2]) 
                { 
                    case "A+":
                        sum += float.Parse(student[1]) * 4.5f;
                        break;
                    case "A0":
                        sum += float.Parse(student[1]) * 4.0f;
                        break;
                    case "B+":
                        sum += float.Parse(student[1]) * 3.5f;
                        break;
                    case "B0":
                        sum += float.Parse(student[1]) * 3.0f;
                        break;
                    case "C+":
                        sum += float.Parse(student[1]) * 2.5f;
                        break;
                    case "C0":
                        sum += float.Parse(student[1]) * 2.0f;
                        break;
                    case "D+":
                        sum += float.Parse(student[1]) * 1.5f;
                        break;
                    case "D0":
                        sum += float.Parse(student[1]) * 1.0f;
                        break;
                    case "F":
                        sum += float.Parse(student[1]) * 0.0f;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum / score);
        }
    }
}
