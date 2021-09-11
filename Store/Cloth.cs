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

        public override string ToString()
        {
            return $"Brand: {this.Brand}, Color: {this.Color.Name}, Size: {this.Size.Name}, Fabric: {this.Fabric.Name}";
        }

    }
}
