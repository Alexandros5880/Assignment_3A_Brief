using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Products;

namespace Products
{
    public class TShirtService : ProductService
    {
        public override Product CreateProduct()
        {
            TShirt tshirt = new TShirt();
            tshirt.Id = HellperClass.GenerateID();
            return new TShirt();
        }
    }
}
