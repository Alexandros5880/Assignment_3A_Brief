using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class TShirt : Product
    {
        public TShirt(string brand, Color color, Size size, Fabric fabric) : 
            base(brand, color, size, fabric)
        {

        }
    }
}
