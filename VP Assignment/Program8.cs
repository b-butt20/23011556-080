using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment
{
    internal class Program8
    {
        public static void MaxorMin()
        {
            Console.WriteLine("Enter 10 numbers in an array");
            int[] num = new int[10];

            for(int a = 0; a < 10; a++)
            {
                Console.WriteLine($"Enter number {a+1}:");
                num[a] = Convert.ToInt32(Console.ReadLine());
            }

            int max = num[0];
            int min = num[0];

            for(int b = 0; b < 10; b++)
            {
                if (num[b]>max)
                {
                    max = num[b];
                }
                else
                {
                    min = num[b];
                }
            }
            Console.WriteLine($"Maximum Number is {max}");
            Console.WriteLine($"Minimum Number is {min}");
        }
    }
}
