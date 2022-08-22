using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HackerEarth_MaximumBorders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                var tbl = Console.ReadLine().Split(' ');
                int row = Int32.Parse(tbl[0]);
                int[] maxNums = new int[row];

                for (int j = 0; j < row; j++)
                {
                    int currentMax = 0;
                    string line = Console.ReadLine();
                    foreach (char c in line)
                    {
                        if (c == '#')
                        {
                            currentMax++;
                        }
                    }
                    maxNums[j] = currentMax;
                }
                Console.WriteLine(maxNums.Max());
            }

        }
    }
}
