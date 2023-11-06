/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob10816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int[] num= new int[20000001];

            int n = int.Parse(sr.ReadLine());
            int[] prob = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0;i < n; i++)
                num[prob[i] + 10000000]++;

            int m = int.Parse(sr.ReadLine());
            int[] tc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for(int i = 0; i < m; i++)
            {
                sb.Append(num[tc[i] + 10000000] + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace Prob10816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            var num = new Dictionary<int, int>();

            int n = int.Parse(sr.ReadLine());
            int[] prob = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int m = int.Parse(sr.ReadLine());
            int[] tc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
            {
                if (!num.ContainsKey(prob[i]))
                    num.Add(prob[i], 1);
                else
                    num[prob[i]]++;
            }

            for (int i = 0; i < m; i++)
            {
                if (!num.ContainsKey(tc[i]))
                    sw.Write(0 + " ");
                else
                    sw.Write(num[tc[i]] + " ");                              
            }
            sw.Close();
            sr.Close();
        }
    }
}
