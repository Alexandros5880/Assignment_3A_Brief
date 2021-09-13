using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
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
        public override string ToString()
        {
            string value = $"T-Shirt: '{this.Brand}' - '{this.Color.Name}' - '{this.Size.Name}' - '{this.Fabric.Name}'";
            foreach (Paynment paynment in this.PaynmentMethods)
            {
                value += $" - '{paynment.ToString()}'";
            }
            return value;
        }
    }
}
