using Products.CFSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Products
{
    public class Product : MakeItDisposable, IProduct
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
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Payinment.Dispose();
                        ////
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}
