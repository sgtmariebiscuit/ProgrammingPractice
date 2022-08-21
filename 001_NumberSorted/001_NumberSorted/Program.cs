using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Checks the current number against the rest of the numbers and if it is bigger than another number in the loop then we replace it with that number
            int[] arr = new int[] { 2, 3, 1, 4, 6, 8, 7, 9, 5, 5, 12, 11, 16, 14, 17 };
            int[] arrSorted = new int[arr.Length];


            for (int i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    int temp = arr[i];
                    if (temp > arr[j])
                    {
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());

            }
            Console.ReadLine();
        }
    }
}