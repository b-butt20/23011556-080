using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment
{
    internal class Program9
    {
        public static void check()
        {
            Console.WriteLine("Enter 10 numbers in array:");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int e =0,O = 0;
            for(int a = 0; a < 10; a++)
            {
                if (num[a] % 2 == 0)
                    {
                        e++;
                    }
                else
                {
                    O++;
                }
            }
            Console.WriteLine($"Even Numbers in array are {e}");
            Console.WriteLine($"Even Numbers in array are {O}");
        }
    }
}
