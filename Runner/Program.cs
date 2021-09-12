using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;
using PaynmentClasses;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Color color = new Color(1, "Green", "#23FF00");
            Size size = new Size(1, "M");
            Fabric fabric = new Fabric(1, "WOOL");
            string brand = "NOTYCA";
            Product tshirt = new TShirt(color, size, fabric ,brand);
            tshirt.AddPaynmentMethod(new CreditCard());
            tshirt.AddPaynmentMethod(new DebitCard());
            tshirt.AddPaynmentMethod(new MoneyBankTransfer());
            tshirt.AddPaynmentMethod(new Cash());

            Console.WriteLine(tshirt.ToString());
            

            Console.ReadKey();

        }
    }
}
