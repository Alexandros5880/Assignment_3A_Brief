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

            Paynment paynment_1 = new IBAN();
            Paynment paynment_2 = new PayPal();
            Paynment paynment_3 = new DebitCard();
            Paynment paynment_4 = new CreditCard();
            Paynment paynment_5 = new Cash();
            Paynment paynment_6 = new WebPaynment();

            Console.WriteLine( paynment_1.ToString() );
            Console.WriteLine( paynment_2.ToString() );
            Console.WriteLine( paynment_3.ToString() );
            Console.WriteLine( paynment_4.ToString() );
            Console.WriteLine( paynment_5.ToString() );
            Console.WriteLine( paynment_6.ToString() );

            Console.WriteLine("");

            string[] types = Paynment.GetTypes();
            foreach(string t in types)
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();

        }
    }
}
