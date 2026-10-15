using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exsercise1
{
    internal class Program
    {
        void RateQtyAmount()
        {
            Double Rate = 0.00;
            Double Qty = 0.00;
            Double Amount = 0.00;

            Console.WriteLine("Enter Qty");
            Qty = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate");
            Rate = Convert.ToDouble(Console.ReadLine());
            Amount = Qty * Rate;
            Console.WriteLine("================");
            Console.WriteLine("Amount=" + Amount);

        }
        void ATM_Menu()
        {
            Double Balance = 1000.00;
            Double Deposite = 0.00;
            Double Withdrow = 0.00;
            int choice;

            do
            {
                Console.WriteLine("===== Welcome To ATM Menu ======");
                Console.WriteLine("\n1.Check Balance\n2.Deposite\n3.Withdrawl\n4.Exit\n");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your Balance is-> " + Balance + " Rs.");
                        break;
                    case 2:
                        Console.WriteLine("Enter Deposite Amount");
                        Deposite = Convert.ToDouble(Console.ReadLine());
                        Balance = Balance + Deposite;
                        Console.WriteLine("Now your Balance is " + Balance + " Rs.");
                        break;
                    case 3:
                        Console.WriteLine("Enter Withdawl Amont");
                        Withdrow = Convert.ToDouble(Console.ReadLine());
                        Balance = Balance - Withdrow;
                        Console.WriteLine("Now your Balance is " + Balance + " Rs.");
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (choice != 4);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // p.RateQtyAmount();
            p.ATM_Menu();
        }
    }
}
