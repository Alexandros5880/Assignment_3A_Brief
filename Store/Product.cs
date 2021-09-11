using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public string Brand { get; set; }

        public Product(string brand, Color color, Size size, Fabric fabric)
        {
            this.Brand = brand;
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
        }

        public override string ToString()
        {
            return $"Brand: {this.Brand}, Color: {this.Color.Name}, Size: {this.Size.Name}, Fabric: {this.Fabric.Name}";
        }
    }
}
