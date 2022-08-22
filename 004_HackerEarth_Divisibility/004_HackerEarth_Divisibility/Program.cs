using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_HackerEarth_Divisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Int32.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            string ans = input[input.Length - 1];

            if (ans[ans.Length - 1] == '0')
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
