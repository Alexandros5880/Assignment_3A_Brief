using Products.Products;
using Products.ProductsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Servicies
{
    public class JacketService : ProductService
    {
        public override Product Create()
        {
            Jacket jacket = new Jacket();
            jacket.Id = HellperClass.GenerateID();
            return jacket;
        }
    }
}
