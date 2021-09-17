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

            Paynment paynment_1 = GetPaynment.GetPayPal();
            Paynment paynment_2 = GetPaynment.GetDebitCard();
            Paynment paynment_3 = GetPaynment.GetCreditCard();
            Paynment paynment_4 = GetPaynment.GetCash();
            Paynment paynment_5 = GetPaynment.GetWebPaynment();

            Console.WriteLine( paynment_1.ToString() );
            Console.WriteLine( paynment_2.ToString() );
            Console.WriteLine( paynment_3.ToString() );
            Console.WriteLine( paynment_4.ToString() );
            Console.WriteLine( paynment_5.ToString() );


            Console.WriteLine("\n");
            
            ProductGenerator pGenarator = new ProductGenerator();
            Product tshirt = pGenarator.CreateTShirt(
                1,
                "NOTYCA", 
                ProductGenerator.ColorValues.INDIGO, 
                ProductGenerator.SizeValues.L,
                ProductGenerator.FabricValues.SILK
            );
            Console.WriteLine(tshirt.ToString());



            Console.ReadKey();

        }
    }
}
