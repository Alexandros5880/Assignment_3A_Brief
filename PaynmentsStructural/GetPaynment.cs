using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaynmentsStractural
{
    public class GetPaynment
    {

        public static string[] GetPaynmentTypes()
        {
            Type[] myTypes = (Type[])Assembly.GetAssembly(typeof(Paynment)).GetTypes().Where(
                    TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof(Paynment))
                ).ToArray();
            List<string> types = new List<string>();
            foreach (Type type in myTypes)
            {
                types.Add(type.Name);
            }
            return types.ToArray();
        }

        public static Paynment GetPayPal()
        {
            return new PayPal();
        }

        public static Paynment GetDebitCard()
        {
            return new DebitCard();
        }

        public static Paynment GetCreditCard()
        {
            return new CreditCard();
        }

        public static Paynment GetCash()
        {
            return new Cash();
        }

        public static Paynment GetWebPaynment()
        {
            return new WebPaynment();
        }

    }
}
