using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.CFSModels;
using Products.Products;

namespace Products
{
    public abstract class ProductService : MakeItDisposable, ICreateService<Product>
    {
        public List<Product> Products { get; private set; } = new List<Product>();
        public abstract Product Create();
        public bool Save(Product product)
        {
            this.Products.Add(product);
            return this.Products.Any();
        }
        public bool Remove(Product product)
        {
            this.Products.Remove(product);
            return this.Products.Any(s => s.Id == product.Id) ? false : true;
        }
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Products.ForEach(p => p.Dispose());
                    this.Products = null;
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}
