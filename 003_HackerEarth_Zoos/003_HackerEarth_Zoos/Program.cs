using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HackerEarth_Zoos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal charZ = 0;
            decimal charO = 0;

            foreach (char c in input)
            {
                if (c == 'z')
                {
                    charZ++;
                }
                else if (c == 'o')
                {
                    charO++;
                }
            }

            if (charO / charZ == 2)
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

