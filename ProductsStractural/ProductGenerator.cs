using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    /* Enums Colors, Sizes, Fabrics
    public enum Sizes
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5,
        XXL = 6,
        XXXL = 7
    }
    public enum Fabrics
    {
        WOOL = 1,
        COTTON = 2,
        POLYESTER = 3,
        RAYON = 4,
        LINEN = 5,
        CASHMERE = 6,
        SILK = 7
    }
    */

    public class ProductGenerator
    {
        internal HashSet<Color> Colors { get; private set; } = new HashSet<Color>();
        public enum ColorValues { RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
        internal HashSet<Size> Sizes { get; private set; } = new HashSet<Size>();
        public enum SizeValues { XXXS, XXS, XS, S, M, L, XL, XXL, XXXL }
        internal HashSet<Fabric> Fabrics { get; private set; } = new HashSet<Fabric>();
        public enum FabricValues { WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }

        public ProductGenerator()
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

        public Product CreateTShirt(int id, string brand, ColorValues color, SizeValues size, FabricValues fabric)
        {
            int colorValue = (int)Enum.Parse(typeof(ColorValues), color.ToString());
            int sizeValue = (int)Enum.Parse(typeof(SizeValues), size.ToString());
            int fabricValue = (int)Enum.Parse(typeof(FabricValues), fabric.ToString());
            return new TShirt(id, brand, this.Colors.ToList()[colorValue], this.Sizes.ToList()[sizeValue], this.Fabrics.ToList()[fabricValue]);
        }
        
    }
}
