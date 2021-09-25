using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.CFS;

namespace Products.Servicies
{
    public class SizeService : ICreateService<Size>
    {
        public List<Size> Sizes { get; private set; } = new List<Size>();
        public Size CreateProduct()
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
            return this.Sizes.Any(s => s.Id == size.Id) ? false : true;
        }
    }
}
