using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    internal abstract class Cloth : Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public string Brand { get; set; }

        public Cloth(string brand, Color color, Size size, Fabric fabric)
        {
            this.Brand = brand;
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
        }
        public Cloth(int id, string brand, Color color, Size size, Fabric fabric) : base(id)
        {
            this.Brand = brand;
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
        }
        public override string ToString()
        {
            return base.ToString() + $"- {this.Brand}  -  {this.Color.Name}  -  {this.Size.Name}  -  {this.Fabric.Name}";
        }
    }
}
