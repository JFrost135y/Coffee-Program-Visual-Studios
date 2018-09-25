using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Menu
    {
        enum MenuItems
        {
            Smallcoffee = 1, Mediumcoffee, Largecoffee, eggsandwich, chickenbiscuit
        }

        static Menu()
        {
            totalcost = 0.00;
            totalsales = 0.00;
            totalprofit = 0.00;
        }

        static double totalcost;
        static double totalsales;
        static double totalprofit;

        public static void DisplayMenu()
        {
            Console.WriteLine("Enter the Menu Item Number");
            Console.WriteLine("\n[1] for Small Coffee");
            Console.WriteLine("[2] for Medium Coffee");
            Console.WriteLine("[3] for Large Coffee");
            Console.WriteLine("[4] for Egg Sandwich");
            Console.WriteLine("[5] for Chicken Biscuit");
            Console.WriteLine("[6] for Finish and Calculate");

            int x = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case (int)MenuItems.Smallcoffee:
                        Console.WriteLine("\nHow many Small Coffees were sold? ");
                        int smallqty = Convert.ToInt32(Console.ReadLine());
                        totalcost += smallqty * 0.10;
                        totalsales += smallqty * 1.00;
                        totalprofit += totalsales - totalcost;
                        Console.WriteLine($"You sold {smallqty} Small Coffees! Press Enter to Return to Menu");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                        break;

                    case (int)MenuItems.Mediumcoffee:
                        Console.WriteLine("\nHow many Medium Coffees were sold? ");
                        int mediumqty = Convert.ToInt32(Console.ReadLine());
                        totalcost += mediumqty * 0.15;
                        totalsales += mediumqty * 3.00;
                        totalprofit += totalsales - totalcost;
                        Console.WriteLine($"You sold {mediumqty} Medium Coffees! Press Enter to Return to Menu");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                        break;

                    case (int)MenuItems.Largecoffee:
                        Console.WriteLine("\nHow many Large Coffees were sold? ");
                        int largeqty = Convert.ToInt32(Console.ReadLine());
                        totalcost += largeqty * 0.20;
                        totalsales += largeqty * 5.00;
                        totalprofit += totalsales - totalcost;
                        Console.WriteLine($"You sold {largeqty} Large Coffees! Press Enter to Return to Menu");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                        break;

                    case (int)MenuItems.eggsandwich:
                        Console.WriteLine("\nHow many Egg Sandwiches were sold? ");
                        int eggsandwichqty = Convert.ToInt32(Console.ReadLine());
                        totalcost += eggsandwichqty * 0.95;
                        totalsales += eggsandwichqty * 5.50;
                        totalprofit += totalsales - totalcost;
                        Console.WriteLine($"You sold {eggsandwichqty} Egg Sandwiches! Press Enter to Return to Menu");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                        break;

                    case (int)MenuItems.chickenbiscuit:
                        Console.WriteLine("\nHow many Chicken Biscuits were sold? ");
                        int chickenbiscuitqty = Convert.ToInt32(Console.ReadLine());
                        totalcost += chickenbiscuitqty * 1.25;
                        totalsales += chickenbiscuitqty * 7.50;
                        totalprofit += totalsales - totalcost;
                        Console.WriteLine($"You sold {chickenbiscuitqty} Chicken Biscuits! Press Enter to Return to Menu");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                        break;

                    case (6):
                        totalprofit = totalsales - totalcost;
                        Console.WriteLine($"\nTotal Cost to us is {totalcost:C}");
                        Console.WriteLine($"Total Sales is {totalsales:C}");
                        Console.WriteLine($"Total Profit is {totalprofit:C}");

                        break;

                    default:
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
            }
            catch (FormatException FEXC)
            {
                Console.WriteLine(FEXC.Message);
            }
            catch (OverflowException OFE)
            {
                Console.WriteLine(OFE.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                Console.WriteLine("\nHave a nice life!");
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

    }
}
