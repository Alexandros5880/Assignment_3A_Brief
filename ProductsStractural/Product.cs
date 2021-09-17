using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    public abstract class Product
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public Product()
        {
            this.Type = this.GetType().Name;
        }
        public Product(int id)
        {
            this.Id = id;
            this.Type = this.GetType().Name;
        }
        public override string ToString()
        {
            return $"ID[{this.Id}] --> {this.Type} ";
        }
    }
}
