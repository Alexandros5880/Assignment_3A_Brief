using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentClasses;

namespace Store
{
    public abstract class Product : IProduct
    {
        public int Id { get; set; }
        public List<Paynment> PaynmentMethods { get; private set; } = new List<Paynment>();
        public bool AddPaynmentMethod(Paynment paynment)
        {
            if(!this.PaynmentMethods.Any(item => item.Type == paynment.Type))
            {
                this.PaynmentMethods.Add(paynment);
            }
            return this.PaynmentMethods.Any(item => item.Type == paynment.Type);
        }
        public bool RemovePaynmentMethod(Paynment paynment)
        {
            if(this.PaynmentMethods.Any(item => item.Type == paynment.Type))
            {
                this.PaynmentMethods.Remove(paynment);
            }
            return this.PaynmentMethods.Any(item => item.Type == paynment.Type);
        }
    }
}
