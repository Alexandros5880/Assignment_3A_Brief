using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;
using Products;


namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {


            while(true)
            {
                Paynment paynment = GetPaynment.SelectPaynment(GetPaynment.HelpTermSelectPaynment());
                Console.WriteLine(paynment.Type);
            }
            


            Console.ReadKey();
        }
    }
}
