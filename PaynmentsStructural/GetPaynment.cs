using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaynmentsStractural
{
    public class GetPaynment
    {

        public static Paynment GetIBAN()
        {
            return new IBAN();
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
