using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Products
{
    public class Product : IProduct
    {
        public string Id { get; set; }
        public string Type { get; private set; }
        public Product()
        {
            this.Type = this.GetType().Name;
        }
        public void SetPaynment()
        {
            throw new NotImplementedException();
        }
        public void GetPaynment()
        {
            throw new NotImplementedException();
        }
    }
}
