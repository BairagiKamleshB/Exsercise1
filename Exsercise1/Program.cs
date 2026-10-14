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
            Qty=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate");
            Rate = Convert.ToDouble(Console.ReadLine());
            Amount = Qty * Rate;
            Console.WriteLine("================");
            Console.WriteLine("Amount=" + Amount);

        }
        static void Main(string[] args)
        {
            Program p =new Program();
            p.RateQtyAmount();
        }
    }
}
