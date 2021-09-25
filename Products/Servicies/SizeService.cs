using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.CFS;
using Products.CFSModels;

namespace Products.Servicies
{
    public class SizeService : MakeItDisposable, ICreateService<Size>
    {
        public List<Size> Sizes { get; private set; } = new List<Size>();
        public Size Create()
        {
            Size size = new Size();
            size.Id = HellperClass.GenerateID();
            return size;
        }
        public bool Save(Size size)
        {
            this.Sizes.Add(size);
            return this.Sizes.Any(s => s.Id == size.Id);
        }
        public bool Remove(Size size)
        {
            this.Sizes.Remove(size);
            size.Dispose();
            return this.Sizes.Any(s => s.Id == size.Id) ? false : true;
        }
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Sizes.ForEach(s => s.Dispose());
                    this.Sizes.Clear();
                    this.Sizes = null;
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}
