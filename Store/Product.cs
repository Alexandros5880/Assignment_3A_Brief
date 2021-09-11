using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product : IProduct
    {
        
        public abstract Paynment paynment { get; set; }

        public Product()
        {

        }

        public String GetPaynmentMethod()
        {
            return this.paynment.ToString();
        }
    }
}
