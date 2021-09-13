using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    public class TShirtGenerator : ClotheGenerator
    {
        public override Product GetCreateProduct()
        {
            return new TShirt(this.color, this.size, this.fabric, this.brand);
        }
    }
}
