using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductFuctory tshirtFuctory = new TShirtFuctory();
            Product tshirt = tshirtFuctory.GetProduct();
            Console.WriteLine(tshirt.ToString());

            Console.ReadKey();

        }
    }
}
