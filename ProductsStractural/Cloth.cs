using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    internal abstract class Cloth : Product, ICloth
    {
        private Color Color { get; set; }
        private Size Size { get; set; }
        private Fabric Fabric { get; set; }
        private string Brand { get; set; }

        public Cloth(int id) : base(id)
        {
            this.LoadLists();
        }

        public void SetBrand(string brand)
        {
            this.Brand = brand;
        }
        public string GetBrand()
        {
            return this.Brand;
        }

        public void SetColor(int index)
        {
            this.Color = this.Colors.ToList()[index];
        }
        public Color GetColor()
        {
            return this.Color;
        }

        public void SetSize(int index)
        {
            this.Size = this.Sizes.ToList()[index];
        }
        public Size GetSize()
        {
            return this.Size;
        }

        public void SetFabric(int index)
        {
            this.Fabric = this.Fabrics.ToList()[index];
        }
        public Fabric GetFabric()
        {
            return this.Fabric;
        }


        internal virtual void LoadLists()
        {
            this.Colors.Add(new Color(this.Colors.Count, "Red", "#FF0000"));
            this.Colors.Add(new Color(this.Colors.Count, "Orange", "#FFA500"));
            this.Colors.Add(new Color(this.Colors.Count, "Yellow", "#FFFF00"));
            this.Colors.Add(new Color(this.Colors.Count, "Green", "#00FF00"));
            this.Colors.Add(new Color(this.Colors.Count, "Blue", "#0000FF"));
            this.Colors.Add(new Color(this.Colors.Count, "Indigo", "#4B0082"));
            this.Colors.Add(new Color(this.Colors.Count, "Violet", "#8F00FF"));

            this.Sizes.Add(new Size(this.Sizes.Count, "XXXS"));
            this.Sizes.Add(new Size(this.Sizes.Count, "XXS"));
            this.Sizes.Add(new Size(this.Sizes.Count, "XS"));
            this.Sizes.Add(new Size(this.Sizes.Count, "S"));
            this.Sizes.Add(new Size(this.Sizes.Count, "M"));
            this.Sizes.Add(new Size(this.Sizes.Count, "L"));
            this.Sizes.Add(new Size(this.Sizes.Count, "XL"));
            this.Sizes.Add(new Size(this.Sizes.Count, "XXL"));
            this.Sizes.Add(new Size(this.Sizes.Count, "XXXL"));

            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "WOOL"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "COTTON"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "POLYESTER"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "RAYON"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "LINEN"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "CASHMERE"));
            this.Fabrics.Add(new Fabric(this.Fabrics.Count, "SILK"));
        }
        public override string ToString()
        {
            return base.ToString() + $"- {this.Brand} - {this.Color.Name} - {this.Size.Name} - {this.Fabric.Name}";
        }
    }
}
