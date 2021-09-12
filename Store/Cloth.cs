using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Cloth : Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public string Brand { get; set; }
        public Cloth(Color color, Size size, Fabric fabric, string brand)
        {
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
            this.Brand = brand;
        }
    }
}
