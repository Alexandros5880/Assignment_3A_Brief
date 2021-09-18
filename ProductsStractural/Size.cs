using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    public class Size
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Size(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"ID[{this.Id}] Name: {this.Name}";
        }
    }
}
