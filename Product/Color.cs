using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }

        public Color(int id, string name, string hex)
        {
            this.Id = id;
            this.Name = name;
            this.Hex = hex;
        }

    }
}
