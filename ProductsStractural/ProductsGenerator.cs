using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    public abstract class ProductsGenerator : IProductGenerator
    {
        public abstract Product GetCreateProduct();
    }
}
