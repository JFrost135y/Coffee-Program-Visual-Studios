using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ISTA_220_LAB_5B_Coffee_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Plese Select Option:");
            Console.WriteLine("\n[1] Calculate Total Sales");
            Console.WriteLine("[2] Calculate Total Wage For Employees");

            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case (1):
                    Console.Clear();
                    Menu.DisplayMenu();
                    break;

                case (2):
                    Console.Clear();
                    Hours.DisplayEmployee();
                    break;

                default:
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
       
    }
    
}
