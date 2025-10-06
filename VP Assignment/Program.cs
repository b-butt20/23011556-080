
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("========= VP Assignment Menu =========");
                Console.WriteLine("1. Check Even or Odd");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Grades");
                Console.WriteLine("4. Sum of Numbers");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("7. Reverse a Number");
                Console.WriteLine("8. Find Max or Min");
                Console.WriteLine("9. Find Maximum and Minimum in Array");
                Console.WriteLine("10. Search in Array");
                Console.WriteLine("0. Exit");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Program1.CheckEvenOdd();
                        break;
                    case 2:
                        Program2.Calculator();
                        break;
                    case 3:
                        Program3.Grades();
                        break;
                    case 4:
                        Program4.sum();
                        break;
                    case 5:
                        Program5.Mutiplication();
                        break;
                    case 6:
                        Program6.Factorial();
                        break;
                    case 7:
                        Program7.Reverse();
                        break;
                    case 8:
                        Program8.MaxorMin();
                        break;
                    case 9:
                        Program9.check();
                        break;
                    case 10:
                        Program10.Search();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        
    }
    }
}
