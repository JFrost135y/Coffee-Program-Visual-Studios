using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        public struct Hours
        {
            enum Employeenames: short
            {
                Employee1,
                Employee2,
                Employee3,
                Employee4,
                Employee5
            }
        public static void DisplayEmployee()
            {
                double wage = 12.50;
                double totalpayroll = 0.00;
                double overtimepay = 18.75;

            try
            {

                Employeenames name1 = Employeenames.Employee1;
                Console.WriteLine(name1);
                Console.WriteLine("\nHow many hours did Employee 1 Work?");
                double E1hours = Convert.ToDouble(Console.ReadLine());
                if (E1hours > 40)
                {
                    double E1totalwithovertime = ((E1hours - 40) * overtimepay) + (40 * wage);
                    Console.WriteLine($"\nEmployee 1 worked {E1hours} hours");
                    Console.WriteLine($"Employee 1 gets paid {E1totalwithovertime:C}");
                    totalpayroll += E1totalwithovertime;
                }
                else
                {
                    double E1wage = (E1hours * wage);
                    Console.WriteLine($"\nEmplyee 1 worked {E1hours} hours");
                    Console.WriteLine($"Employee 1 gets paid {E1wage:C}");
                    totalpayroll += E1wage;
                }

                Employeenames name2 = Employeenames.Employee2;
                Console.WriteLine(name2);
                Console.WriteLine("\nHow many hours did Employee 2 Work?");
                double E2hours = Convert.ToDouble(Console.ReadLine());
                if (E2hours > 40)
                {
                    double E2totalwithovertime = ((E2hours - 40) * overtimepay) + (40 * wage);
                    Console.WriteLine($"\nEmployee 2 worked {E2hours} hours");
                    Console.WriteLine($"Employee 2 gets paid {E2totalwithovertime:C}");
                    totalpayroll += E2totalwithovertime;
                }
                else
                {
                    double E2wage = (E2hours * wage);
                    Console.WriteLine($"\nEmployee 2 worked {E2hours} hours");
                    Console.WriteLine($"Employee 2 gets paid {E2wage:C}");
                    totalpayroll += E2wage;
                }
                Employeenames name3 = Employeenames.Employee3;
                Console.WriteLine(name3);
                Console.WriteLine("\nHow many hours did Employee 3 Work?");
                double E3hours = Convert.ToDouble(Console.ReadLine());
                if (E3hours > 40)
                {
                    double E3totalwithovertime = ((E3hours - 40) * overtimepay) + (40 * wage);
                    Console.WriteLine($"\nEmployee 3 worked {E3hours} hours");
                    Console.WriteLine($"Employee 3 gets paid {E3totalwithovertime:C}");
                    totalpayroll += E3totalwithovertime;
                }
                else
                {
                    double E3wage = (E3hours * wage);
                    Console.WriteLine($"\nEmployee 3 worked {E3hours} hours");
                    Console.WriteLine($"Employee 3 gets paid {E3wage:C}");
                    totalpayroll += E3wage;
                }
                Employeenames name4 = Employeenames.Employee4;
                Console.WriteLine(name4);
                Console.WriteLine("\nHow many hours did Employee 4 Work?");
                double E4hours = Convert.ToDouble(Console.ReadLine());
                if (E4hours > 40)
                {
                    double E4totalwithovertime = ((E4hours - 40) * overtimepay) + (40 * wage);
                    Console.WriteLine($"\nEmployee 4 worked {E4hours} hours");
                    Console.WriteLine($"Employee 4 gets paid {E4totalwithovertime:C}");
                    totalpayroll += E4totalwithovertime;
                }
                else
                {
                    double E4wage = (E4hours * wage);
                    Console.WriteLine($"\nEmployee 4 worked {E4hours} hours");
                    Console.WriteLine($"Employee 4 gets paid {E4wage:C}");
                    totalpayroll += E4wage;
                }
                Employeenames name5 = Employeenames.Employee5;
                Console.WriteLine(name5);
                Console.WriteLine("\nHow many hours did Employee 5 Work?");
                double E5hours = Convert.ToDouble(Console.ReadLine());
                if (E5hours > 40)
                {
                    double E5totalwithovertime = ((E5hours - 40) * overtimepay) + (40 * wage);
                    Console.WriteLine($"\nEmployee 5 worked {E5hours} hours");
                    Console.WriteLine($"Employee 5 gets paid {E5totalwithovertime:C}");
                    totalpayroll += E5totalwithovertime;
                }
                else
                {
                    double E5wage = (E5hours * wage);
                    Console.WriteLine($"\nEmployee 5 worked {E5hours} hours");
                    Console.WriteLine($"Employee 5 gets paid {E5wage:C}");
                    totalpayroll += E5wage;
                }

                Console.WriteLine($"\nTotal amout to pay employees is {totalpayroll:C}");
                Console.ReadLine();
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
