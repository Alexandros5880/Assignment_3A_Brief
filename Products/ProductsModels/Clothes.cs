using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Servicies;
using Products.CFS;

namespace Products.Products
{
    public class Clothes : Product
    {
        public static SizeService SizeService { get; private set; } = new SizeService();
        public Size SelectedSize { get; set; }
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.SelectedSize.Dispose();
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}