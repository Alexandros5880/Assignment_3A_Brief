using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    internal class TShirt : Cloth
    {
        public TShirt(string brand, Color color, Size size, Fabric fabric) : 
            base(brand, color, size, fabric)
        {
            
        }

        public TShirt(int id, string brand, Color color, Size size, Fabric fabric) :
            base(id, brand, color, size, fabric)
        {

        }
    }
}
