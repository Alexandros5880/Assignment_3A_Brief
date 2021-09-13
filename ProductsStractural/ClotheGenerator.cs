using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    public abstract class ClotheGenerator : ProductsGenerator
    {
        public List<Color> AvailableColors = new List<Color>();
        public List<Size> AvailableSizes = new List<Size>();
        public List<Fabric> AvailableFabrics = new List<Fabric>();

        protected Color color;
        protected Size size;
        protected Fabric fabric;
        protected string brand;
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void SetSize(Size size)
        {
            this.size = size;
        }
        public void SetFabric(Fabric fabric)
        {
            this.fabric = fabric;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
    }
}
