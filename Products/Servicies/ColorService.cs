using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Servicies
{
    public class ColorService : ICreateService<Color>
    {
        public List<Color> Colors { get; private set; } = new List<Color>();
        public Color CreateProduct()
        {
            Color color = new Color();
            color.Id = HellperClass.GenerateID();
            return color;
        }
        public bool Save(Color color)
        {
            this.Colors.Add(color);
            return this.Colors.Any(c => c.Id == color.Id);
        }
        public bool Remove(Color color)
        {
            this.Colors.Remove(color);
            return this.Colors.Any(s => s.Id == color.Id) ? false : true;
        }
    }
}
