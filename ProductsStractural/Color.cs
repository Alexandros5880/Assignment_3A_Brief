using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    internal class Color
    {
        public int Id { get;  private set; }
        public string Name { get; set; }
        public string Hex { get; set; }

        public Color(int id, string name, string hex)
        {
            this.Id = id;
            this.Name = name;
            this.Hex = hex;
        }

        public override string ToString()
        {
            return $"ID [{this.Id}] --> {this.Name}: {this.Hex}";
        }
    }
}
