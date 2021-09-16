using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;
using ProductsStractural;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Paynment paynment_1 = GetPaynment.GetIBAN();
            Paynment paynment_2 = GetPaynment.GetPayPal();
            Paynment paynment_3 = GetPaynment.GetDebitCard();
            Paynment paynment_4 = GetPaynment.GetCreditCard();
            Paynment paynment_5 = GetPaynment.GetCash();
            Paynment paynment_6 = GetPaynment.GetWebPaynment();

            Console.WriteLine( paynment_1.ToString() );
            Console.WriteLine( paynment_2.ToString() );
            Console.WriteLine( paynment_3.ToString() );
            Console.WriteLine( paynment_4.ToString() );
            Console.WriteLine( paynment_5.ToString() );
            Console.WriteLine( paynment_6.ToString() );
            

            Console.ReadKey();

        }
    }
}
