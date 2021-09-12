using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentClasses;

namespace Store
{
    public class TShirt : Cloth
    {
        public TShirt(Color color, Size size, Fabric fabric, string brand) : 
            base(color, size, fabric, brand)
        {
            
        }
        public override string ToString()
        {
            string value = $"T-Shirt: '{this.Brand}' - '{this.Color.Name}' - '{this.Size.Name}' - '{this.Fabric.Name}'";
            foreach(Paynment paynment in this.PaynmentMethods)
            {
                value += $" - '{paynment.ToString()}'";
            }
            return value;
        }
    }
}
