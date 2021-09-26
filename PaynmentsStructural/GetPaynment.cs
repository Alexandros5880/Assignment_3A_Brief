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
        public static int HelpTermSelectPaynment()
        {
            int count = 0;
            Paynment.All.ForEach(t => { Console.WriteLine($"Index[{count++}]: {t.Name}"); });
            return int.Parse(Console.ReadLine());
        }
        public static List<System.Type> GetPaynments()
        {
            return Paynment.All;
        }
        public static Paynment SelectPaynment(int index)
        {
            return (Paynment)Activator.CreateInstance(Paynment.All[index]);
        }

        /*
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

        public static void PrintTypesPlus()
        {
            Console.WriteLine($"SubClasses Count: {Paynment.All.Count}");
            foreach (System.Type p in Paynment.All)
            {
                Console.WriteLine($"\n\n{p.Name}:");
                // var obj = Activator.CreateInstance(p);
                foreach (MethodInfo method in p.GetMethods())
                {
                    Console.WriteLine($"    {method.Name}()");
                    if (method.GetParameters().Length > 0)
                    {
                        Console.Write("        Parameters: ");
                        foreach (ParameterInfo pa in method.GetParameters())
                        {
                            Console.Write(pa.Name + ", ");
                        }
                        Console.WriteLine("");
                    }
                    //method.Invoke(obj);
                }
            }
        }
        */
    }
}
